using BusinessObject;

namespace DataAccess.DAO
{
    public class CartDAO
    {
        private static CartDAO? _instance;
        private static readonly object InstanceLock = new object();
        private static Dictionary<int, CartProduct> _cart;
        private CartDAO() { }
        public static CartDAO GetCartDao
        {
            get
            {
                lock (InstanceLock)
                {
                    return _instance ??= new CartDAO();
                }
            }
        }
        public Dictionary<int, CartProduct> GetCart() => _cart;
        public void AddToCart(int productId, int quantity, decimal price)
        {
            _cart ??= new Dictionary<int, CartProduct>();
            if (_cart.ContainsKey(productId))
            {
                _cart.TryGetValue(productId, out var cartProduct);
                if (cartProduct != null)
                {
                    quantity = cartProduct.Quantity + quantity;
                }
                _cart[productId] = new CartProduct()
                {
                    Price = price,
                    Quantity = quantity
                };
            }
            else
            {
                _cart.Add(productId, new CartProduct()
                {
                    Quantity = quantity,
                    Price = price
                });
            }
        }
        public void RemoveFromCart(int productId)
        {
            if (_cart == null)
            {
                return;
            }
            if (_cart.ContainsKey(productId))
            {
                _cart.Remove(productId);
            }
            if (_cart.Count == 0)
            {
                DeleteCart();
            }
        }
        public void UpdateCart(int productId, int quantity, decimal price)
        {
            if (_cart == null)
            {
                return;
            }
            if (_cart.ContainsKey(productId))
            {
                _cart[productId] = new CartProduct()
                {
                    Price = price,
                    Quantity = quantity
                };
            }
        }

        public void DeleteCart()
        {
            _cart = null;
        }
    }
}
