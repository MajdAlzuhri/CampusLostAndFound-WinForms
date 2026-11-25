using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmAddEditItem : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _ItemID = -1;
        private string _ItemType = "Lost";
        private clsItem _Item;

        public frmAddEditItem(string itemType)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _ItemType = itemType;
        }

        public frmAddEditItem(int itemID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ItemID = itemID;
        }

        private void _SetMaxLengths()
        {
            // Match SQL Server VARCHAR limits to prevent truncation exceptions
            txtItemName.MaxLength = 100;
            txtColor.MaxLength = 30;
            txtLocation.MaxLength = 100;
            txtDescription.MaxLength = 500;
        }

        private void _ResetDefaultValues()
        {
            _SetMaxLengths();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = $"Add New {_ItemType} Item";
                _Item = new clsItem();
                _Item.ItemType = _ItemType;

                // New items must always start as "Open"
                cbStatus.SelectedIndex = 0; // "Open"
                cbStatus.Enabled = false;
            }
            else
            {
                lblTitle.Text = $"Update {_ItemType} Item";
                cbStatus.Enabled = true;
            }

            lblItemID.Text = "???";
            txtItemName.Text = "";
            cbCategory.SelectedIndex = 0;
            txtColor.Text = "";
            dtpItemDate.Value = DateTime.Now;
            txtLocation.Text = "";
            txtDescription.Text = "";
        }

        private void _LoadData()
        {
            _Item = clsItem.Find(_ItemID);

            if (_Item == null)
            {
                MessageBox.Show("No Item with ID = " + _ItemID, "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            _ItemType = _Item.ItemType;
            lblTitle.Text = $"Update {_ItemType} Item";
            lblItemID.Text = _Item.ItemID.ToString();
            txtItemName.Text = _Item.ItemName;

            int catIndex = cbCategory.FindString(_Item.Category);
            cbCategory.SelectedIndex = (catIndex != -1) ? catIndex : 0;

            txtColor.Text = _Item.Color;
            dtpItemDate.Value = _Item.ItemDate;

            int statusIndex = cbStatus.FindString(_Item.Status);
            cbStatus.SelectedIndex = (statusIndex != -1) ? statusIndex : 0;

            txtLocation.Text = _Item.Location;
            txtDescription.Text = _Item.Description;

            // Lock editing if item is already Returned (unless Admin)
            if (_Item.Status == "Returned" && (clsGlobal.CurrentUser == null || clsGlobal.CurrentUser.Role != "Admin"))
            {
                pnlCard.Enabled = false;
                btnSave.Enabled = false;
                MessageBox.Show("This item is already marked as Returned and cannot be edited by staff.", "Read Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAddEditItem_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _ValidateInputs()
        {
            string itemName = txtItemName.Text.Trim();
            string color = txtColor.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemName) || itemName.Length < 3)
            {
                MessageBox.Show("Item Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }

            // Prevent purely numeric item names like "12345"
            if (itemName.All(char.IsDigit))
            {
                MessageBox.Show("Item Name cannot be numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }

            // Color (if entered) must contain letters/spaces/hyphens only — no numbers or symbols
            if (!string.IsNullOrEmpty(color) && !Regex.IsMatch(color, @"^[a-zA-Z\s\-]+$"))
            {
                MessageBox.Show("Color must contain letters only (e.g., Black, Dark Blue). Numbers and symbols are not allowed.", "Invalid Color", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtColor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(location) || location.Length < 3)
            {
                MessageBox.Show("Please enter a valid campus location (at least 3 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return false;
            }

            if (dtpItemDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputs())
                return;

            if (_Item == null)
                _Item = new clsItem();

            _Item.ItemName = txtItemName.Text.Trim();
            _Item.Category = cbCategory.Text;
            _Item.Color = txtColor.Text.Trim();
            _Item.ItemDate = dtpItemDate.Value.Date;
            _Item.Location = txtLocation.Text.Trim();
            _Item.Status = (_Mode == enMode.AddNew) ? "Open" : cbStatus.Text;
            _Item.Description = txtDescription.Text.Trim();

            if (_Mode == enMode.AddNew)
            {
                _Item.ItemType = _ItemType;
                _Item.CreatedBy = (clsGlobal.CurrentUser != null) ? clsGlobal.CurrentUser.UserID : -1;
            }

            if (_Item.Save())
            {
                lblItemID.Text = _Item.ItemID.ToString();
                _Mode = enMode.Update;
                cbStatus.Enabled = true;
                lblTitle.Text = $"Update {_ItemType} Item";

                MessageBox.Show("Item Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Item Was Not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}