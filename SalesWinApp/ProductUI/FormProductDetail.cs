using AutoMapper;
using DataAccess.Repository.CartRepository;
using DataAccess.Repository.CategoryRepository;
using DataAccess.Repository.ProductRepository;
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

namespace SalesWinApp.ProductUI
{
    public partial class FormProductDetail : Form
    {
        public bool IsAdminLogin { get; init; }
        public bool IsMemberLogin { get; init; }
        public bool InsertOrUpdate { get; init; }
        public MemberPresenter LoginMember { get; init; }
        public IProductRepository ProductRepository { get; init; }
        private readonly ICategoryRepository categoryRepository = new CategoryRepository();
        public ICartRepository CartRepository { get; init; }
        public ProductPresenter ProductInfo { get; init; }
        private readonly IMapper mapper;

        public FormProductDetail()
        {
            InitializeComponent();
            mapper = new MapperConfiguration(config => {
                config.AddProfile(new MappingProfileConfiguration());
            }).CreateMapper();
        }
    }
}
