using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmAddEditClaim : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _ClaimID = -1;
        private clsClaim _Claim;
        private clsItem _VerifiedItem;

        public frmAddEditClaim()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditClaim(int claimID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ClaimID = claimID;
        }

        private void _ResetDefaultValues()
        {
            txtClaimantName.MaxLength = 100;
            txtPhone.MaxLength = 20;
            txtVerificationResult.MaxLength = 255;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Claim";
                _Claim = new clsClaim();
                cbClaimStatus.SelectedIndex = 0; // "Pending"
                cbClaimStatus.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update Claim";
                cbClaimStatus.Enabled = true;
                txtItemID.Enabled = false;
                btnFindItem.Enabled = false;
            }

            lblClaimID.Text = "???";
            txtItemID.Text = "";
            txtClaimantName.Text = "";
            txtPhone.Text = "";
            txtVerificationResult.Text = "";
        }

        private bool _VerifyAndPreviewItem(int itemID, bool showErrors = true)
        {
            clsItem item = clsItem.Find(itemID);

            if (item == null)
            {
                lblItemPreview.ForeColor = Color.FromArgb(185, 28, 28);
                lblItemPreview.Text = "Item not found in database!";
                _VerifiedItem = null;
                return false;
            }

            if (_Mode == enMode.AddNew)
            {
                if (item.ItemType != "Found")
                {
                    lblItemPreview.ForeColor = Color.FromArgb(185, 28, 28);
                    lblItemPreview.Text = $"Invalid: Item #{itemID} is a 'Lost' report, not a 'Found' item.";
                    _VerifiedItem = null;
                    return false;
                }

                if (item.Status != "Open")
                {
                    lblItemPreview.ForeColor = Color.FromArgb(185, 28, 28);
                    lblItemPreview.Text = $"Unavailable: Item #{itemID} status is already '{item.Status}'.";
                    _VerifiedItem = null;
                    return false;
                }
            }

            _VerifiedItem = item;
            lblItemPreview.ForeColor = Color.FromArgb(5, 150, 105);
            lblItemPreview.Text = $"✔ {item.ItemName} ({item.Category} - {item.Color}) | Status: {item.Status}";
            return true;
        }

        private void _LoadData()
        {
            _Claim = clsClaim.Find(_ClaimID);

            if (_Claim == null)
            {
                MessageBox.Show("No Claim with ID = " + _ClaimID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblClaimID.Text = _Claim.ClaimID.ToString();
            txtItemID.Text = _Claim.ItemID.ToString();
            _VerifyAndPreviewItem(_Claim.ItemID, false);

            txtClaimantName.Text = _Claim.ClaimantName;
            txtPhone.Text = _Claim.Phone;
            txtVerificationResult.Text = _Claim.VerificationResult;

            int statusIdx = cbClaimStatus.FindString(_Claim.ClaimStatus);
            cbClaimStatus.SelectedIndex = (statusIdx != -1) ? statusIdx : 0;

            // Lock finalized claims for regular Staff (Admin can still edit)
            if (_Claim.ClaimStatus != "Pending" && (clsGlobal.CurrentUser == null || clsGlobal.CurrentUser.Role != "Admin"))
            {
                pnlCard.Enabled = false;
                btnSave.Enabled = false;
                MessageBox.Show("Finalized claims can only be modified by an Administrator.", "Read Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAddEditClaim_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemID.Text.Trim(), out int itemID))
            {
                MessageBox.Show("Please enter a valid numeric Item ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _VerifyAndPreviewItem(itemID);
        }

        private void txtItemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool _ValidateInputs()
        {
            if (!int.TryParse(txtItemID.Text.Trim(), out int itemID))
            {
                MessageBox.Show("Please enter a valid Item ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemID.Focus();
                return false;
            }

            if (_Mode == enMode.AddNew && !_VerifyAndPreviewItem(itemID))
            {
                MessageBox.Show("Please select an available 'Found' item with 'Open' status.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string name = txtClaimantName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3 || !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Claimant Name must contain letters only (at least 3 characters).", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaimantName.Focus();
                return false;
            }

            string phone = txtPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone) || phone.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number (at least 10 digits).", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputs())
                return;

            int itemID = int.Parse(txtItemID.Text.Trim());

            if (_Mode == enMode.AddNew && clsClaim.HasActiveClaimForItem(itemID))
            {
                MessageBox.Show("This item already has a Pending or Approved claim!",
                    "Duplicate Claim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Claim == null)
                _Claim = new clsClaim();

            _Claim.ItemID = itemID;
            _Claim.ClaimantName = txtClaimantName.Text.Trim();
            _Claim.Phone = txtPhone.Text.Trim();
            _Claim.VerificationResult = txtVerificationResult.Text.Trim();

            if (_Mode == enMode.AddNew)
            {
                _Claim.ClaimStatus = "Pending";
                _Claim.CreatedBy = (clsGlobal.CurrentUser != null) ? clsGlobal.CurrentUser.UserID : -1;
            }
            else
            {
                _Claim.ClaimStatus = cbClaimStatus.Text;
            }

            bool saved = (_Claim.ClaimStatus == "Approved" && _Mode == enMode.Update)
                ? _Claim.Approve(_Claim.VerificationResult)
                : _Claim.Save();

            if (saved)
            {
                lblClaimID.Text = _Claim.ClaimID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Claim";
                MessageBox.Show("Claim Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Could not save claim (item may already have an approved claim).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}