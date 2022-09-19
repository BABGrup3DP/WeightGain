using System.Data.Entity;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class CategoryRepository
    {
        WeightGainContext DbContext;
        DbSet<Category> _categories;

        public CategoryRepository()
        {
            DbContext = new WeightGainContext();
            _categories = DbContext.Set<Category>();
        }

        //kategori ekleme
        public bool Insert(Category category)
        {
            _categories.Add(category);
            return DbContext.SaveChanges() > 0;
        }

        //kategori güncellem
        public bool Update(Category category)
        {
            Category updateCategory = _categories.Find(category.CategoryID);
            updateCategory.Description = category.Description;
            updateCategory.Name = category.Name;
            updateCategory.Picture = category.Picture;
            updateCategory.Products = category.Products;
            return DbContext.SaveChanges() > 0;
        }

        //kategori silme
        public bool Delete(Category category)
        {
            _categories.Remove(category);
            return DbContext.SaveChanges() > 0;
        }
    }
}
