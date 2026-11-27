using System;
using System.Data;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmManageCategories : Form
    {
        private int _SelectedCategoryID = -1;

        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void _RefreshCategoriesList()
        {
            DataTable dtFromDB = clsCategory.GetAllCategories();

            // إنشاء جدول عرض يحتوي على ترقيم تسلسلي خاص بالـ GridView مع إبقاء CategoryID مخفياً
            DataTable dtDisplay = new DataTable();
            dtDisplay.Columns.Add("RowNo", typeof(int));
            dtDisplay.Columns.Add("CategoryID", typeof(int));
            dtDisplay.Columns.Add("CategoryName", typeof(string));

            int counter = 1;
            foreach (DataRow row in dtFromDB.Rows)
            {
                dtDisplay.Rows.Add(counter++, row["CategoryID"], row["CategoryName"]);
            }

            dgvCategories.DataSource = dtDisplay;
            lblRecordCount.Text = dgvCategories.Rows.Count.ToString();

            if (dgvCategories.Columns.Count > 0)
            {
                dgvCategories.Columns["RowNo"].HeaderText = "#";
                dgvCategories.Columns["RowNo"].FillWeight = 12;

                // إخفاء الـ ID الحقيقي المخزن في قاعدة البيانات
                dgvCategories.Columns["CategoryID"].Visible = false;

                dgvCategories.Columns["CategoryName"].HeaderText = "Category Name";
                dgvCategories.Columns["CategoryName"].FillWeight = 88;
            }

            _ResetSelection();
        }

        private void _ResetSelection()
        {
            _SelectedCategoryID = -1;
            txtCategoryName.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvCategories.ClearSelection();
            txtCategoryName.Focus();
        }

        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            _RefreshCategoriesList();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCategories.CurrentRow == null)
                return;

            // قراءة الـ CategoryID الحقيقي من العمود المخفي لتنفيذ التعديل أو الحذف بدقة
            _SelectedCategoryID = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName) || categoryName.Length < 2)
            {
                MessageBox.Show("Please enter a valid category name (at least 2 characters).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            if (clsCategory.AddCategory(categoryName))
            {
                MessageBox.Show("Category Added Successfully.", "Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshCategoriesList();
            }
            else
            {
                MessageBox.Show("Failed to add category. It may already exist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_SelectedCategoryID <= 0) return;

            string newName = txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || newName.Length < 2)
            {
                MessageBox.Show("Please enter a valid category name (at least 2 characters).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            if (clsCategory.UpdateCategory(_SelectedCategoryID, newName))
            {
                MessageBox.Show("Category Updated Successfully.", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshCategoriesList();
            }
            else
            {
                MessageBox.Show("Failed to update category. Name may already exist or is unchanged.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_SelectedCategoryID <= 0) return;

            string categoryName = txtCategoryName.Text.Trim();

            if (MessageBox.Show($"Are you sure you want to delete category [{categoryName}]?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsCategory.DeleteCategory(_SelectedCategoryID))
                {
                    MessageBox.Show("Category Deleted Successfully.", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCategoriesList();
                }
                else
                {
                    MessageBox.Show("Unable to delete this category.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ResetSelection();
        }
    }
}