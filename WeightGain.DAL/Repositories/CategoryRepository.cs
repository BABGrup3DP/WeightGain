using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class CategoryRepository : BaseRepository
    {
        private readonly DbSet<Category> _categories;

        public CategoryRepository()
        {
            _categories = WeightGainContext.Set<Category>();
        }

        //kategori ekleme
        public bool Insert(Category category)
        {
            try
            {
                _categories.Add(category);
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //kategori güncelleme
        public bool Update(Category category)
        {
            try
            {
                var updateCategory = _categories.Find(category.CategoryId);
                if (updateCategory == null) return false;
                updateCategory.Description = category.Description;
                updateCategory.Name = category.Name;
                updateCategory.Products = category.Products;
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //kategori silme
        public bool Delete(int categoryId)
        {
            try
            {
                var deleteCategory = _categories.Find(categoryId);
                if (deleteCategory != null)
                    _categories.Remove(deleteCategory);
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }

        }

        public List<Category> GetAll() => _categories.ToList();

    }
}
