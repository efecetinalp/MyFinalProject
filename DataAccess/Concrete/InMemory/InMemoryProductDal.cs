using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName= "Laptop", UnitPrice=1000, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName= "Camera", UnitPrice=800, UnitsInStock=10},
                new Product{ProductId=3, CategoryId=2, ProductName= "Table", UnitPrice=200, UnitsInStock=35},
                new Product{ProductId=4, CategoryId=2, ProductName= "Chair", UnitPrice=80, UnitsInStock=50},
                new Product{ProductId=5, CategoryId=2, ProductName= "Lamp", UnitPrice=50, UnitsInStock=22}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
