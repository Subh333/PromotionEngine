using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductPromotion;
using Stripe;

namespace ProductPromotionTestProject
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void TestCartTotalPrice() {

            ProductService service = new ProductService();
            //Order1
            Order order = new Order(1, new List<Product>() {
                new Product("A"),
                new Product("B"),
                new Product("C"),
                new Product("D") });
            var resultPrice = service.GetTotalCartPrice(order);
            Assert.AreEqual(100, resultPrice, "Mismatch With discount promotion");

            //Order 2
            Order order2 = new Order(1, new List<Product>() {
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C") });
            var resultPrice2 = service.GetTotalCartPrice(order2);
            Assert.AreEqual(275, resultPrice2, "Mismatch With discount promotion");


        }
    }
}
