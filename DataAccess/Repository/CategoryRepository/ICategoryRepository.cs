using BusinessObject;

namespace DataAccess.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategoryList();
        public Category GetCategory(int categoryId);
        public Category GetCategory(string categoryName);
        public void AddCategory(string categoryName);
    }
}
