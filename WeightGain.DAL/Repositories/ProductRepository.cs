using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class ProductRepository : BaseRepository
    {
        private readonly DbSet<Product> _products;

        public ProductRepository()
        {
            _products = WeightGainContext.Set<Product>();
        }

        //ürün ekleme
        public bool Insert(Product product)
        {
            try
            {
                _products.Add(product);
                return WeightGainContext.SaveChanges() > 0;
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
                var updateProduct = _products.Find(product.ProductId);
                if (updateProduct == null) return false;
                updateProduct.ProductName = product.ProductName;
                updateProduct.Scale = product.Scale;
                updateProduct.Calory = product.Calory;
                updateProduct.CategoryId = product.CategoryId;
                updateProduct.Picture = product.Picture;
                return WeightGainContext.SaveChanges() > 0;

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
                return _products.Find(id);
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
                var deleteProduct = _products.Find(productId);
                if (deleteProduct != null)
                    _products.Remove(deleteProduct);
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> GetByCategoryId(int categoryId) => _products.Where(x => x.CategoryId == categoryId).ToList();

        public List<Product> GetAll() => _products.ToList();
    }
}
