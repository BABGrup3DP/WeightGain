using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class ProductRepository : BaseRepository
    {
        private readonly DbSet<Product> Products;
        private readonly DbSet<Category> Categories;

        public ProductRepository()
        {
            Products = weightGainContext.Set<Product>();
            Categories = weightGainContext.Set<Category>();
        }

        //ürün ekleme

        public bool Insert(Product product)
        {
            try
            {
                Products.Add(product);
                return weightGainContext.SaveChanges() > 0;
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
                var updateProduct = Products.Find(product.ProductId);
                if (updateProduct == null) return false;
                updateProduct.ProductName = product.ProductName;
                updateProduct.Scale = product.Scale;
                updateProduct.Calory = product.Calory;
                updateProduct.Category = product.Category;
                return weightGainContext.SaveChanges() > 0;

            }
            catch
            {
                return false;
            }
        }

        public Product GetById(object id)
        {
            try
            {
                return Products.Find(id);
            }
            catch
            {
                return null;
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
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> GetByCategoryId(int categoryId) =>
            Products.Where(x => x.CategoryId == categoryId).ToList();

        public List<Product> GetAll() => Products.ToList();
    }
}
