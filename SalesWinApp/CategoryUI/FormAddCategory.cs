using DataAccess.Repository.CategoryRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.CategoryUI
{
    public partial class FormAddCategory : Form
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public FormAddCategory()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            try
            {
                if (categoryName == String.Empty)
                {
                    throw new FormatException("Categogy name can't empty!");
                }
                else
                {
                    CategoryRepository.AddCategory(categoryName);
                    MessageBox.Show(@"Add Category with the name: " + categoryName + @" successfully!!", @"Add new Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Add new Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
