using AutoMapper;
using BusinessObject;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.OrderRepository;
using SalesWinApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        CultureInfo culutreInfo = new CultureInfo("vi-VN");
        public FormOrderDetails()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfileConfiguration());
            });
            mapper = config.CreateMapper();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                int orderId = OrderPresenter.OrderId;
                string memberName = OrderPresenter.MemberName;
                DateTime orderDate = OrderPresenter.OrderDate;
                decimal orderTotal = OrderPresenter.OrderTotal;
                IEnumerable<OrderDetail> orderDetails = orderDetailRepository.GetOrderDetails(orderId);
                cartPresenters = orderDetails.Select(order => mapper.Map<OrderDetail, CartPresenter>(order));

                source = new BindingSource();
                source.DataSource = cartPresenters;

                txtOderID.Text = orderId.ToString();
                txtOrderDate.Text = orderDate.Date.ToString(culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy");
                txtOrderTotal.Text = orderTotal.ToString(CultureInfo.CurrentCulture);
                txtMemberName.Text = memberName;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;

                btnDelete.Visible = IsAdminLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Load Order Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"Are you really want to delete this order:" +
                    $@"Order ID: {OrderPresenter.OrderId}" +
                    $@"Member: {OrderPresenter.MemberName}" +
                    $@"Order Date: {OrderPresenter.OrderDate}" +
                    $@"Order Total: {OrderPresenter.OrderTotal}?", @"Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int orderId = OrderPresenter.OrderId;
                    orderDetailRepository.DeleteOrderDetails(orderId);
                    orderRepository.DeleteOrder(orderId);
                    MessageBox.Show(@"Delete Order Successfully!", @"Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
