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

        private void _ReNumberRows()
        {
            if (dgvLostItems.Columns.Contains("RowNo"))
            {
                for (int i = 0; i < dgvLostItems.Rows.Count; i++)
                {
                    dgvLostItems.Rows[i].Cells["RowNo"].Value = i + 1;
                }
            }
        }

        private void _RefreshLostItemsList()
        {
            _dtLostItems = clsItem.GetAllLostItems();

            if (!_dtLostItems.Columns.Contains("RowNo"))
            {
                _dtLostItems.Columns.Add("RowNo", typeof(int));
                _dtLostItems.Columns["RowNo"].SetOrdinal(0);
            }

            for (int i = 0; i < _dtLostItems.Rows.Count; i++)
            {
                _dtLostItems.Rows[i]["RowNo"] = i + 1;
            }

            dgvLostItems.DataSource = _dtLostItems;
            lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();

            if (dgvLostItems.Columns.Count > 0)
            {
                dgvLostItems.Columns["RowNo"].HeaderText = "#";
                dgvLostItems.Columns["RowNo"].Width = 45;

                // إخفاء الـ ID الحقيقي المخزن في قاعدة البيانات
                dgvLostItems.Columns["ItemID"].Visible = false;

                dgvLostItems.Columns["ItemName"].HeaderText = "Item Name";
                dgvLostItems.Columns["Category"].HeaderText = "Category";
                dgvLostItems.Columns["Color"].HeaderText = "Color";
                dgvLostItems.Columns["ItemDate"].HeaderText = "Date Lost";
                dgvLostItems.Columns["Location"].HeaderText = "Location";
                dgvLostItems.Columns["Status"].HeaderText = "Status";

                if (dgvLostItems.Columns.Contains("ReportedBy"))
                    dgvLostItems.Columns["ReportedBy"].HeaderText = "Reported By";
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
                    _ReNumberRows();
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

            _ReNumberRows();
            lblRecordCount.Text = dgvLostItems.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtLostItems == null) return;
            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Item ID":
                    filterColumn = "ItemID";
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
                _ReNumberRows();
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

            _ReNumberRows();
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

            string currentStatus = dgvLostItems.CurrentRow.Cells["Status"].Value.ToString();
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
            int itemID = (int)dgvLostItems.CurrentRow.Cells["ItemID"].Value;
            frmAddEditItem frm = new frmAddEditItem(itemID);
            frm.ShowDialog();
            _RefreshLostItemsList();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLostItems.CurrentRow == null) return;

            int itemID = (int)dgvLostItems.CurrentRow.Cells["ItemID"].Value;
            string itemName = dgvLostItems.CurrentRow.Cells["ItemName"].Value.ToString();

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

            int itemID = (int)dgvLostItems.CurrentRow.Cells["ItemID"].Value;
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

            int itemID = (int)dgvLostItems.CurrentRow.Cells["ItemID"].Value;

            if (MessageBox.Show("Move selected Lost Item to Found Items?", "Confirm Transfer",
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