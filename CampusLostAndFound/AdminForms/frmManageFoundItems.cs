using System;
using System.Data;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmManageFoundItems : Form
    {
        private DataTable _dtFoundItems;

        public frmManageFoundItems()
        {
            InitializeComponent();
        }

        private void _ReNumberRows()
        {
            if (dgvFoundItems.Columns.Contains("RowNo"))
            {
                for (int i = 0; i < dgvFoundItems.Rows.Count; i++)
                {
                    dgvFoundItems.Rows[i].Cells["RowNo"].Value = i + 1;
                }
            }
        }

        private void _RefreshFoundItemsList()
        {
            _dtFoundItems = clsItem.GetAllFoundItems();

            if (!_dtFoundItems.Columns.Contains("RowNo"))
            {
                _dtFoundItems.Columns.Add("RowNo", typeof(int));
                _dtFoundItems.Columns["RowNo"].SetOrdinal(0);
            }

            for (int i = 0; i < _dtFoundItems.Rows.Count; i++)
            {
                _dtFoundItems.Rows[i]["RowNo"] = i + 1;
            }

            dgvFoundItems.DataSource = _dtFoundItems;
            lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();

            if (dgvFoundItems.Columns.Count > 0)
            {
                dgvFoundItems.Columns["RowNo"].HeaderText = "#";
                dgvFoundItems.Columns["RowNo"].Width = 45;

                // إخفاء الـ ID الحقيقي المخزن في قاعدة البيانات
                dgvFoundItems.Columns["ItemID"].Visible = false;

                dgvFoundItems.Columns["ItemName"].HeaderText = "Item Name";
                dgvFoundItems.Columns["Category"].HeaderText = "Category";
                dgvFoundItems.Columns["Color"].HeaderText = "Color";
                dgvFoundItems.Columns["Location"].HeaderText = "Location";
                dgvFoundItems.Columns["ItemDate"].HeaderText = "Date Found";
                dgvFoundItems.Columns["Status"].HeaderText = "Status";
            }

            dgvFoundItems.ClearSelection();
        }

        private void frmManageFoundItems_Load(object sender, EventArgs e)
        {
            _RefreshFoundItemsList();
            cbFilterBy.SelectedIndex = 0;

            // Only Admin can delete items
            if (clsGlobal.CurrentUser != null &&
                !string.Equals(clsGlobal.CurrentUser.Role, "Admin", StringComparison.OrdinalIgnoreCase))
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
                else if (_dtFoundItems != null)
                {
                    _dtFoundItems.DefaultView.RowFilter = "";
                    _ReNumberRows();
                    lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
                }
            }
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtFoundItems == null) return;

            if (cbStatusFilter.Text == "All")
                _dtFoundItems.DefaultView.RowFilter = "";
            else
                _dtFoundItems.DefaultView.RowFilter = string.Format("[Status] = '{0}'", cbStatusFilter.Text);

            _ReNumberRows();
            lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtFoundItems == null) return;
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
                case "Color":
                    filterColumn = "Color";
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
                _dtFoundItems.DefaultView.RowFilter = "";
                _ReNumberRows();
                lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Item ID")
            {
                if (int.TryParse(rawText, out int id))
                    _dtFoundItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, id);
            }
            else
            {
                string safeValue = clsGlobal.EscapeRowFilterValue(rawText);
                _dtFoundItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, safeValue);
            }

            _ReNumberRows();
            lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Item ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsFoundItems_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvFoundItems.Rows.Count == 0 || dgvFoundItems.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            string status = dgvFoundItems.CurrentRow.Cells["Status"].Value.ToString();
            markAsClaimedToolStripMenuItem.Enabled = (status == "Open");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddEditItem frm = new frmAddEditItem("Found");
            frm.ShowDialog();
            _RefreshFoundItemsList();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;
            int itemID = (int)dgvFoundItems.CurrentRow.Cells["ItemID"].Value;
            frmAddEditItem frm = new frmAddEditItem(itemID);
            frm.ShowDialog();
            _RefreshFoundItemsList();
        }

        private void markAsClaimedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;
            int itemID = (int)dgvFoundItems.CurrentRow.Cells["ItemID"].Value;
            string itemName = dgvFoundItems.CurrentRow.Cells["ItemName"].Value.ToString();

            if (MessageBox.Show($"Mark [{itemName}] as Claimed?", "Confirm Status Change",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsItem item = clsItem.Find(itemID);
                if (item != null)
                {
                    item.Status = "Claimed";
                    if (item.Save())
                    {
                        MessageBox.Show("Item status updated to Claimed.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshFoundItemsList();
                    }
                }
            }
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;
            int itemID = (int)dgvFoundItems.CurrentRow.Cells["ItemID"].Value;
            string itemName = dgvFoundItems.CurrentRow.Cells["ItemName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete [{itemName}]?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsItem.DeleteItem(itemID))
                {
                    MessageBox.Show("Item Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshFoundItemsList();
                }
            }
        }
    }
}