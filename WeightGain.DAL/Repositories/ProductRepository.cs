using System.Data.Entity;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class ProductRepository
    {
        WeightGainContext DbContext;
        DbSet<Product> _products;

        public ProductRepository()
        {
            DbContext = new WeightGainContext();
            _products = DbContext.Set<Product>();
        }

        //ürün ekleme

        public bool Insert(Product product)
        {
            _products.Add(product);
            return DbContext.SaveChanges() > 0;
        }

        //ürün güncelleme
        public bool Update(Product product)
        {
            Product updateProduct = _products.Find(product.ProductID);
            updateProduct.ProductName = product.ProductName;
            updateProduct.Scale = product.Scale;
            updateProduct.Calory = product.Calory;
            updateProduct.Category = product.Category;
            return DbContext.SaveChanges() > 0;
        }

        //ürün silme
        public bool Delete(Product product)
        {
            _products.Remove(product);
            return DbContext.SaveChanges() > 0;
        }
    }
}
