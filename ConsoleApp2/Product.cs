using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductPromotion;

public class Product {
    public string Id { get; set; }
    public int Price { get; set; }

    public Product(string id) {
        this.Id = id;
    }

}

