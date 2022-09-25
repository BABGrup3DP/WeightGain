using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class CategoryRepository : BaseRepository
    {
        private readonly DbSet<Category> _categories;

        public CategoryRepository()
        {
            _categories = weightGainContext.Set<Category>();
        }

        //kategori ekleme
        public bool Insert(Category category)
        {
            _categories.Add(category);
            return weightGainContext.SaveChanges() > 0;
        }

        //kategori güncellem
        public bool Update(Category category)
        {
            Category updateCategory = _categories.Find(category.CategoryId);
            updateCategory.Description = category.Description;
            updateCategory.Name = category.Name;
            //updateCategory.Picture = category.Picture;
            updateCategory.Products = category.Products;
            return weightGainContext.SaveChanges() > 0;
        }

        //kategori silme
        public bool Delete(int categoryId)
        {
            var deleteCategory = _categories.Find(categoryId);
            if (deleteCategory != null)
                _categories.Remove(deleteCategory);
            return weightGainContext.SaveChanges() > 0;
        }

        public List<Category> GetAll() => _categories.ToList();

        public Category GetById(int categoryID) => _categories.Find(categoryID);
    }
}
