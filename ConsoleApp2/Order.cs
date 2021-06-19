using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Order class which calculate the order from Cart.
   public class Order {
        public int OrderID { get; set; }
        public List<Product> Products { get; set; }

        public Order(int id, List<Product> products) {
            this.OrderID = id;
            this.Products = products;
        }
}

