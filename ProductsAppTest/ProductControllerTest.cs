using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsApp.Controllers;
using ProductsApp.Models;

namespace ProductsAppTest
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetAllProductsTest()
        {
            var testProducts = GetTestProducts() as List<Product>;
            var controller = new ProductController(testProducts);
            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.count);
        }
            private List<Product> GetTestProducts()
            {
             var testProducts = new List<Product>();                
            testProducts.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            testProducts.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            testProducts.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });
            testProducts.Add(new Product { Id = 4, Name = "Soup", Category = "Groceries", Price = 1 });
            testProducts.Add(new Product { Id = 5, Name = "Car", Category = "Toys", Price = 3.75M });
            testProducts.Add(new Product { Id = 6, Name = "Knife", Category = "Hardware", Price = 16.99M });           
            return testProducts;
            }

        }
    }

