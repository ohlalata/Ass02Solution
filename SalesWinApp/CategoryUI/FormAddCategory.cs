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
    }
}
