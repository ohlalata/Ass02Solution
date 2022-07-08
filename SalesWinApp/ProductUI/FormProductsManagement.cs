using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CartRepository;
using DataAccess.Repository.MemberRepository;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.ProductRepository;
using SalesWinApp.Presenter;

namespace SalesWinApp.ProductUI
{
    public partial class FormProductsManagement : Form
    {
        public bool IsAdminLogin { get; init; }
        public bool IsMemberLogin { get; init; }
        public MemberPresenter MemberLogin { get; init; }
        public IMemberRepository MemberRepository { get; init; }

        private readonly IProductRepository productRepository = new ProductRepository();
        public ICartRepository CartRepository { get; init; } = new CartRepository();

        private BindingSource source;
        private IEnumerable<Product> originalProductsResult;
        private IEnumerable<Product> searchAndApplyFilterProductsResult;

        private readonly IMapper mapper;
        private readonly IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public FormProductsManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(config => { config.AddProfile(new MappingProfileConfiguration()); });
            mapper = config.CreateMapper();
        }
    }
}
