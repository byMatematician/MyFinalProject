using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // Oracle, Sql server, Posthres, MongoDb
            _products = new List<Product> {
                new Product{ProductId = 1,CategoryId = 1, ProductName = "Cup", UnitPrice  = 15, UnitsInStock = 15},
                new Product{ProductId = 2,CategoryId = 1, ProductName = "Keyboerd", UnitPrice  = 150, UnitsInStock = 5},
                new Product{ProductId = 3,CategoryId = 1, ProductName = "Mobile", UnitPrice  = 1500, UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId = 1, ProductName = "Camera", UnitPrice  = 500, UnitsInStock = 65},
                new Product{ProductId = 5,CategoryId = 1, ProductName = "mouse", UnitPrice  = 85, UnitsInStock = 1},


            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            // Lambda

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getall()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products;
        }

        

        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> Getll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // Gønderdigim urun Id'sine sahip olan listedeki urunu  bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
