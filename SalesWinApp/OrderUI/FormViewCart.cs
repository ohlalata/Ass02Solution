using DataAccess.Repository.CartRepository;
using DataAccess.Repository.MemberRepository;
using DataAccess.Repository.OrderRepository;
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
    public partial class FormViewCart : Form
    {
        public MemberPresenter LoginMember { get; init; }
        public bool IsAdminLogin { get; init; }
        public bool IsMemberLogin { get; init; }
        public IMemberRepository MemberRepository { get; init; }
        public ICartRepository CartRepository { get; init; }
        private readonly IOrderRepository orderRepository = new OrderRepository();


        BindingSource source;
        public FormViewCart()
        {
            InitializeComponent();

        }
    }
}
