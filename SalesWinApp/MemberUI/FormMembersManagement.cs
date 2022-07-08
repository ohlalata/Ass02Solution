using AutoMapper;
using DataAccess.Repository.CartRepository;
using DataAccess.Repository.MemberRepository;
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

namespace SalesWinApp.MemberUI
{
    public partial class FormMembersManagement : Form
    {
        public bool IsAdminLogin { get; init; }
        public bool IsMemberLogin { get; init; }
        public MemberPresenter LoginMember { get; init; }
        readonly IMemberRepository memberRepository = new MemberRepository();
        private readonly ICartRepository cartRepository = new CartRepository();
        private readonly IOrderRepository orderRepository = new OrderRepository();
        private readonly IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private BindingSource membersBindingSource;
        private BindingSource cityFilter;
        private BindingSource countryFilter;
        private readonly IMapper mapper;
        private IEnumerable<MemberPresenter> originalMembersResult;
        private IEnumerable<MemberPresenter> searchAndApplyFilterMembersResult;

        public FormMembersManagement()
        {
            InitializeComponent();
            mapper = new MapperConfiguration(config => { config.AddProfile(new MappingProfileConfiguration()); })
                .CreateMapper();
        }
    }
}
