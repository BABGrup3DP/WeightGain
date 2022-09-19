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
        private readonly DbSet<Category> Categories;

        public CategoryRepository()
        {
            _dbContext = new WeightGainContext();
            Categories = _dbContext.Set<Category>();
        }

        //kategori ekleme
        public bool Insert(Category category)
        {
            Categories.Add(category);
            return _dbContext.SaveChanges() > 0;
        }

        //kategori güncellem
        public bool Update(Category category)
        {
            Category updateCategory = Categories.Find(category.CategoryID);
            updateCategory.Description = category.Description;
            updateCategory.Name = category.Name;
            //updateCategory.Picture = category.Picture;
            updateCategory.Products = category.Products;
            return _dbContext.SaveChanges() > 0;
        }

        //kategori silme
        public bool Delete(Category category)
        {
            Categories.Remove(category);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Category> GetAll() => Categories.ToList();
    }
}
