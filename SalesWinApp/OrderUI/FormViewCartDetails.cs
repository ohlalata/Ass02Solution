using DataAccess.Repository.CartRepository;
using SalesWinApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.OrderUI
{
    public partial class FormViewCartDetails : Form
    {
        public ICartRepository CartRepository { get; init; }
        public CartPresenter CartPresenter { get; init; }

        public FormViewCartDetails()
        {
            InitializeComponent();
        }
    }
}
