using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductPromotion;

   public class ProductService: IProductService {

    public int GetTotalCartPrice(Order order) {

        var distinctIDs = order.Products.Select(x => x.Id).Distinct();
        //Get promotional Price
        var promotions = IncludePromotions();
        int sum = 0;
        foreach (var id in distinctIDs) {
            //Get the the Count of SKU ids for each order
            var countIDs = order.Products.Count(x => x.Id == id);

            var promotionOffer = promotions.FirstOrDefault(d => d.PromotionId == id.ToString());

            //Calculation Logic
            if (promotionOffer != null) {
                sum = sum + (countIDs / promotionOffer.PromotionIdNumbers) * promotionOffer.PromoPrice
                      + (countIDs % promotionOffer.PromotionIdNumbers) * GetProductPrice(id);
            }

        }
       
        return sum;
    }

    private IList<PromotionCode> IncludePromotions() {
        
        //Create Promotional Offer List
        List<PromotionCode> promotions = new List<PromotionCode>()
                {
                    new PromotionCode("A", 3, 130),
                    new PromotionCode("B", 2, 45),
                    new PromotionCode("C", 1, 20)
                };

        return promotions;
    }

    private int GetProductPrice(string id) {
        int price = 0;
        switch (id)
        {
            case "A":
                price = 50;
                break;
            case "B":
                price = 30;
                break;
            case "C":
                price = 20;
                break;
            case "D":
                price = 15;
                break;
        }
        return price;

    }
}

