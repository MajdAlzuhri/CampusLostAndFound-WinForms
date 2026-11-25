using System;
using System.Data;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmManageLostItems : Form
    {
        private DataTable _dtLostItems;

        public frmManageLostItems()
        {
            InitializeComponent();
        }

        private void _RefreshLostItemsList()
        {
            _dtLostItems = clsItem.GetAllLostItems();
            dgvLostItems.DataSource = _dtLostItems;
            lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();

            if (dgvLostItems.Rows.Count > 0)
            {
                dgvLostItems.Columns[0].HeaderText = "Item ID";
                dgvLostItems.Columns[1].HeaderText = "Item Name";
                dgvLostItems.Columns[2].HeaderText = "Category";
                dgvLostItems.Columns[3].HeaderText = "Color";
                dgvLostItems.Columns[4].HeaderText = "Date Lost";
                dgvLostItems.Columns[5].HeaderText = "Location";
                dgvLostItems.Columns[6].HeaderText = "Status";
                dgvLostItems.Columns[7].HeaderText = "Reported By";
            }

            dgvLostItems.ClearSelection();
        }

        private void frmManageLostItems_Load(object sender, EventArgs e)
        {
            _RefreshLostItemsList();
            cbFilterBy.SelectedIndex = 0;

            // Only Admin can delete items
            if (clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.Role != "Admin")
            {
                deleteItemToolStripMenuItem.Visible = false;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatusFilter.Visible = true;
                cbStatusFilter.BringToFront();
                cbStatusFilter.Focus();
                cbStatusFilter.SelectedIndex = 0;
            }
            else
            {
                cbStatusFilter.Visible = false;
                txtFilterValue.Visible = (cbFilterBy.Text != "None");

                if (txtFilterValue.Visible)
                {
                    txtFilterValue.BringToFront();
                    txtFilterValue.Text = "";
                    txtFilterValue.Focus();
                }
                else if (_dtLostItems != null)
                {
                    _dtLostItems.DefaultView.RowFilter = "";
                    lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();
                }
            }
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtLostItems == null) return;

            if (cbStatusFilter.Text == "All")
                _dtLostItems.DefaultView.RowFilter = "";
            else
                _dtLostItems.DefaultView.RowFilter = string.Format("[Status] = '{0}'", cbStatusFilter.Text);

            lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtLostItems == null) return;
            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Item ID":
                    filterColumn = _dtLostItems.Columns[0].ColumnName;
                    break;
                case "Item Name":
                    filterColumn = "ItemName";
                    break;
                case "Category":
                    filterColumn = "Category";
                    break;
                case "Location":
                    filterColumn = "Location";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            string rawText = txtFilterValue.Text.Trim();

            if (rawText == "" || filterColumn == "None")
            {
                _dtLostItems.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Item ID")
            {
                if (int.TryParse(rawText, out int id))
                    _dtLostItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, id);
            }
            else
            {
                string safeValue = clsGlobal.EscapeRowFilterValue(rawText);
                _dtLostItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, safeValue);
            }

            lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Item ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsLostItems_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvLostItems.Rows.Count == 0 || dgvLostItems.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            string currentStatus = dgvLostItems.CurrentRow.Cells[6].Value.ToString();
            bool isOpen = (currentStatus == "Open");

            markAsReturnedToolStripMenuItem.Enabled = isOpen;
            moveToFoundItemsToolStripMenuItem.Enabled = isOpen;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddEditItem frm = new frmAddEditItem("Lost");
            frm.ShowDialog();
            _RefreshLostItemsList();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLostItems.CurrentRow == null) return;
            int itemID = (int)dgvLostItems.CurrentRow.Cells[0].Value;
            frmAddEditItem frm = new frmAddEditItem(itemID);
            frm.ShowDialog();
            _RefreshLostItemsList();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLostItems.CurrentRow == null) return;

            int itemID = (int)dgvLostItems.CurrentRow.Cells[0].Value;
            string itemName = dgvLostItems.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete [{itemName}]?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsItem.DeleteItem(itemID))
                {
                    MessageBox.Show("Item Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshLostItemsList();
                }
                else
                {
                    MessageBox.Show("Cannot delete this item because it has linked claims.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void markAsReturnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLostItems.CurrentRow == null) return;

            int itemID = (int)dgvLostItems.CurrentRow.Cells[0].Value;
            clsItem item = clsItem.Find(itemID);

            if (item != null)
            {
                item.Status = "Returned";
                if (item.Save())
                {
                    MessageBox.Show("Item marked as Returned.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshLostItemsList();
                }
            }
        }

        private void moveToFoundItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLostItems.CurrentRow == null) return;

            int itemID = (int)dgvLostItems.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Move Lost Item #{itemID} to Found Items?", "Confirm Transfer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsItem item = clsItem.Find(itemID);
                if (item != null)
                {
                    item.ItemType = "Found";
                    item.Status = "Open";

                    if (item.Save())
                    {
                        MessageBox.Show("Item successfully moved to Found Items!", "Moved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshLostItemsList();
                    }
                }
            }
        }
    }
}