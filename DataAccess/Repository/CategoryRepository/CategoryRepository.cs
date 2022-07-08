using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(string categoryName) => CategoryDAO.GetCategoryDao.AddCategory(categoryName);

        public Category GetCategory(int categoryId)
        {
            return CategoryDAO.GetCategoryDao.GetCategory(categoryId);
        }

        public Category GetCategory(string categoryName)
        {
            return CategoryDAO.GetCategoryDao.GetCategory(categoryName);
        }

        public IEnumerable<Category> GetCategoryList()
        {
            return CategoryDAO.GetCategoryDao.GetCategoryList();
        }
    }
}
