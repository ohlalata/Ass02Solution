using AutoMapper;
using DataAccess.Repository.OrderDetailRepo;
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
    public partial class FormOrderDetails : Form
    {
        public MemberPresenter MemberLogin { get; set; }
        public OrderPresenter OrderPresenter { get; set; }
        public bool IsAdminLogin { get; init; }
        public bool IsMemberLogin { get; init; }

        private readonly IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private readonly IOrderRepository orderRepository = new OrderRepository();
        private IEnumerable<CartPresenter> cartPresenters;
        private readonly IMapper mapper;
        BindingSource source;
        public FormOrderDetails()
        {
            InitializeComponent();
        }
    }
}
