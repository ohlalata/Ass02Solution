using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CartRepository;
using DataAccess.Repository.MemberRepository;
using SalesWinApp.Presenter;
using SalesWinApp.ProductUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = false;
            if (InsertOrUpdate) // Insert
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtMemberID.Enabled = false;

                txtMemberID.Text = MemberInfo.MemberId.ToString();
                txtMemberName.Text = MemberInfo.Fullname;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtConfirm.Text = MemberInfo.Password;
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
            }

            if (IsAdminLogin)
            {
                MenuStrip mainMenu = new MenuStrip();
                this.Controls.Add(mainMenu);
                this.MainMenuStrip = mainMenu;

                ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
                ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                // Main Menu
                mainMenu.Items.AddRange(new ToolStripItem[]
                {
                    menuOrder,
                    menuExit
                });

                menuOrder.Click += menuOrder_Click;
                menuExit.Click += menuExit_Click;
            }
        }
        private void menuOrder_Click(object sender, EventArgs e)
        {
            FormProductsManagement formProductsManagement = new FormProductsManagement()
            {
                MemberLogin = this.IsMemberLogin ? MemberInfo : null,
                IsAdminLogin = this.IsAdminLogin,
                IsMemberLogin = this.IsMemberLogin,
                MemberRepository = this.MemberRepository,
                CartRepository = this.CartRepository
            };
            formProductsManagement.Closed += (_, _) => this.Close();
            this.Hide();
            formProductsManagement.Show();
        }
        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberName.Text.Trim() == String.Empty)
                {
                    throw new Exception("Member Name is not empty!");
                }
                var CheckEmail = new EmailAddressAttribute();
                if (!CheckEmail.IsValid(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (txtPassword.Text.Trim() == String.Empty)
                {
                    throw new Exception("Password is not empty!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!");
                }
                if (txtCompanyName.Text.Trim() == String.Empty)
                {
                    throw new Exception("CompanyName is not empty!");
                }
                if (txtCity.Text.Trim() == String.Empty)
                {
                    throw new Exception("City is not empty!");
                }
                if (txtCountry.Text.Trim() == String.Empty)
                {
                    throw new Exception("Country is not empty!");
                }
                if ((txtCity.Text).Any(char.IsDigit))
                {
                    throw new Exception("Wrong City!");
                }
                if ((txtCountry.Text).Any(char.IsDigit))
                {
                    throw new Exception("Wrong Country!");
                }

                MemberPresenter memberPresenter = new MemberPresenter
                {
                    MemberId = MemberInfo.MemberId,
                    Fullname = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                Member member = mapper.Map<Member>(memberPresenter);

                MemberRepository.UpdateMember(member);
                MemberInfo = mapper.Map<MemberPresenter>(member);
                MessageBox.Show(@"Update successfully!!", @"Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMemberName.Text = member.Fullname;
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtConfirm.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberName.Text.Trim() == String.Empty)
                {
                    throw new Exception("Member Name is not empty!");
                }
                var CheckEmail = new EmailAddressAttribute();
                if (!CheckEmail.IsValid(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (txtPassword.Text.Trim() == String.Empty)
                {
                    throw new Exception("Password is not empty!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!");
                }
                if (txtCompanyName.Text.Trim() == String.Empty)
                {
                    throw new Exception("CompanyName is not empty!");
                }
                if (txtCity.Text.Trim() == String.Empty)
                {
                    throw new Exception("City is not empty!");
                }
                if (txtCountry.Text.Trim() == String.Empty)
                {
                    throw new Exception("Country is not empty!");
                }
                if ((txtCity.Text).Any(char.IsDigit))
                {
                    throw new Exception("Wrong City!");
                }
                if ((txtCountry.Text).Any(char.IsDigit))
                {
                    throw new Exception("Wrong Country!");
                }

                MemberPresenter memberPresenter = new MemberPresenter
                {
                    Fullname = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                Member member = mapper.Map<Member>(memberPresenter);
                MemberRepository.AddMember(member);
                MessageBox.Show(@"Add successfully!!", @"Add new member", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Add new member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IsAdminLogin)
            {
                Close();
            }
            if (IsMemberLogin)
            {
                FormProductsManagement formProductsManagement = new FormProductsManagement()
                {
                    IsMemberLogin = IsMemberLogin,
                    IsAdminLogin = IsAdminLogin,
                    MemberLogin = MemberInfo,
                    MemberRepository = new MemberRepository()
                };
                formProductsManagement.Closed += (_, _) => Close();
                formProductsManagement.Show();
            }
        }
    }
}
