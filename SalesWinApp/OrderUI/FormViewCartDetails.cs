using DataAccess.Repository.CartRepository;
using DataAccess.Repository.ProductRepository;
using SalesWinApp.Presenter;
using System.Globalization;

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
        private void frmViewCartDetails_Load(object sender, EventArgs e)
        {
            try
            {
                numUnitPrice.Maximum = decimal.MaxValue;
                IProductRepository productRepository = new ProductRepository();
                numQuantity.Maximum = productRepository.GetProduct(CartPresenter.ProductName).UnitsInStock;
                txtProductName.Text = CartPresenter.ProductName;
                numUnitPrice.Value = CartPresenter.Price;
                numQuantity.Value = CartPresenter.Quantity;
                txtTotal.Text = CartPresenter.Total.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"View Cart Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                IProductRepository productRepository = new ProductRepository();
                int productId = productRepository.GetProduct(CartPresenter.ProductName).ProductId;
                if (numQuantity.Value == 0)
                {
                    CartRepository.RemoveFromCart(productId);
                }
                else
                {
                    CartRepository.UpdateCart(productId, Convert.ToInt32(numQuantity.Value), numUnitPrice.Value);
                }
                MessageBox.Show(@"Update successfully!", @"Update Cart Item", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Update Cart Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal newTotal = numUnitPrice.Value * numQuantity.Value;
            txtTotal.Text = newTotal.ToString(CultureInfo.CurrentCulture);
        }
    }
}
