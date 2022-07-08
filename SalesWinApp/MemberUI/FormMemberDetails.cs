using AutoMapper;
using DataAccess.Repository.CartRepository;
using DataAccess.Repository.MemberRepository;
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
    public partial class FormMemberDetails : Form
    {
        public bool IsAdminLogin { get; init; }
        public bool IsMemberLogin { get; init; }
        public bool InsertOrUpdate { get; init; }
        public IMemberRepository MemberRepository { get; init; }
        public ICartRepository CartRepository { get; init; }
        public MemberPresenter MemberInfo { get; set; }
        private readonly IMapper mapper;


        public FormMemberDetails()
        {
            InitializeComponent();

            mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MappingProfileConfiguration());
            }).CreateMapper();
        }
    }
}
