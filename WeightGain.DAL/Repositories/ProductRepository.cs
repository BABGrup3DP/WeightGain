using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DbContext.Products.Add(product);
            return DbContext.SaveChanges()>0;
        }

        //ürün güncelleme
        public bool Update(Product product)
        {
            Product updateProduct = DbContext.Products.Find(product.ProductID);
            updateProduct.ProductName = product.ProductName;
            updateProduct.Scale = product.Scale;
            updateProduct.Calory=product.Calory;
            updateProduct.Category = product.Category;
            return DbContext.SaveChanges() > 0;
        }

        //ürün silme
        public bool Delete(Product product)
        {
            DbContext.Products.Remove(product);
            return DbContext.SaveChanges()>0;
        }
    }
}
