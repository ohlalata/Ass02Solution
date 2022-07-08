using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository.CartRepository
{
    public class CartRepository
    {
        public void AddToCart(int productId, int quantity, decimal price) => CartDAO.GetCartDao.AddToCart(productId, quantity, price);

        public Dictionary<int, CartProduct> GetCart() => CartDAO.GetCartDao.GetCart();

        public void RemoveFromCart(int productId) => CartDAO.GetCartDao.RemoveFromCart(productId);

        public void UpdateCart(int productId, int quantity, decimal price) => CartDAO.GetCartDao.UpdateCart(productId, quantity, price);
        public void DeleteCart() => CartDAO.GetCartDao.DeleteCart();
    }
}
