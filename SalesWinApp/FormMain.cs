using DataAccess.Repository.CartRepository;
using DataAccess.Repository.MemberRepository;
using SalesWinApp.Presenter;

namespace SalesWinApp
{
    public partial class FormMain : Form
    {
        public IMemberRepository MemberRepository { get; init; }
        public ICartRepository CartRepository { get; init; }
        public bool IsAdminLogin { get; init; }
        private bool IsMemberLogin { get; set; } = false;
        private MemberPresenter MemberLogin { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }
    }
}
