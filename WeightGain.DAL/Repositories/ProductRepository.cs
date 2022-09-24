using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class ProductRepository
    {
        private readonly WeightGainContext _dbContext;
        private readonly DbSet<Product> Products;
        private readonly DbSet<Category> Categories;

        public ProductRepository()
        {
            _dbContext = new WeightGainContext();
            Products = _dbContext.Set<Product>();
            Categories = _dbContext.Set<Category>();
        }

        //ürün ekleme

        public bool Insert(Product product)
        {
            try
            {
                Products.Add(product);
                return _dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //ürün güncelleme
        public bool Update(Product product)
        {
            try
            {
                var updateProduct = Products.Find(product.ProductID);
                if (updateProduct == null) return false;
                updateProduct.ProductName = product.ProductName;
                updateProduct.Scale = product.Scale;
                updateProduct.Calory = product.Calory;
                updateProduct.Category = product.Category;
                return _dbContext.SaveChanges() > 0;

            }
            catch
            {
                return false;
            }
        }

        //ürün silme
        public bool Delete(int productId)
        {
            try
            {
                var deleteProduct = Products.Find(productId);
                if (deleteProduct != null)
                    Products.Remove(deleteProduct);
                return _dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> GetByCategoryId(int categoryId) =>
            Products.Where(x => x.CategoryID == categoryId).ToList();

        public List<Product> GetAll() => Products.ToList();
    }
}
