using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class CategoryRepository
    {
        private readonly WeightGainContext _dbContext;
        private readonly DbSet<Category> _categories;

        public CategoryRepository()
        {
            _dbContext = new WeightGainContext();
            _categories = _dbContext.Set<Category>();
        }

        //kategori ekleme
        public bool Insert(Category category)
        {
            _categories.Add(category);
            return _dbContext.SaveChanges() > 0;
        }

        //kategori güncellem
        public bool Update(Category category)
        {
            Category updateCategory = _categories.Find(category.CategoryID);
            updateCategory.Description = category.Description;
            updateCategory.Name = category.Name;
            //updateCategory.Picture = category.Picture;
            updateCategory.Products = category.Products;
            return _dbContext.SaveChanges() > 0;
        }

        //kategori silme
        public bool Delete(int categoryID)
        {
            var deleteCategory = _categories.Find(categoryID);
            if (deleteCategory != null)
            _categories.Remove(deleteCategory);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Category> GetAll() => _categories.ToList();

        public Category GetById(int categoryID) => _categories.Find(categoryID);
    }
}
