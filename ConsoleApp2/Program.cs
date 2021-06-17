using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPromotion
{
    class Program
    {
        static void Main(string[] args) {

            //Accept Orders from User Input
            //List<Order> orders = new List<Order>();
            //Console.WriteLine("Please Enter Total Number of cart orders");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{

            //    List<Product> products = new List<Product>();
            //    Console.WriteLine("Please Enter Qunity with SKU IDs");
            //    string typeOfSkuIDs = Console.ReadLine();
            //    Product p = new Product(typeOfSkuIDs);
            //    products.Add(p);
            //    orders.Add
            //}

            //create orders
            List<Order> orders = new List<Order>();
            Order order1 = new Order(1, new List<Product>(){
                new Product("A"), 
                new Product("B"),
                new Product("C") });
            Order order2 = new Order(2, new List<Product>() {
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C") });
            Order order3 = new Order(3, new List<Product>() { 
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C"),
                new Product("D") });
            orders.AddRange(new Order[] { order1, order2, order3 });

            //Calling Product service to fetch the Total Calculated Price
            ProductService productService = new ProductService();
            foreach (var order in orders) {
                int totalPrice = productService.GetTotalCartPrice(order);
                Console.WriteLine("Cart Price\n {0}", totalPrice);
                Console.ReadLine();
            }

           
        }
    }
}
