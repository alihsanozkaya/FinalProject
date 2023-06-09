﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                new Product{ProductID = 1, CategoryID = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductID = 2, CategoryID = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductID = 3, CategoryID = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductID = 4, CategoryID = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductID = 5, CategoryID = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product); 
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
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

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
