using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product) => ProductDAO.GetProductDao.AddProduct(product);

        public void Delete(int productId) => ProductDAO.GetProductDao.Delete(productId);


        public Product GetProduct(int productId, IEnumerable<Product> searchList = null)
        {
            return ProductDAO.GetProductDao.GetProductByProductId(productId, searchList);
        }
        public Product GetProduct(string productName, IEnumerable<Product> searchList = null)
        {
            return ProductDAO.GetProductDao.GetProductByProductName(productName, searchList);
        }

        public IEnumerable<Product> GetProductsList() => ProductDAO.GetProductDao.GetProductsList();


        public IEnumerable<Product> SearchProduct(string name, IEnumerable<Product> searchList = null)
        {
            return ProductDAO.GetProductDao.SearchProduct(name, searchList);
        }

        public IEnumerable<Product> SearchProduct(int startUnit, int endUnit, IEnumerable<Product> searchList = null)
        {
            return ProductDAO.GetProductDao.SearchProduct(startUnit, endUnit, searchList);
        }

        public IEnumerable<Product> SearchProduct(decimal startPrice, decimal endPrice, IEnumerable<Product> searchList = null)
        {
            return ProductDAO.GetProductDao.SearchProduct(startPrice, endPrice, searchList);
        }

        public void Update(Product product) => ProductDAO.GetProductDao.Update(product);
    }
}
