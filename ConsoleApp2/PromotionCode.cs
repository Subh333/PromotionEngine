using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PromotionCode {
        public string PromotionId { get; set; }
        public int PromotionIdNumbers { get; set; }
        public int PromoPrice { get; set; }

        public PromotionCode(string promId, int promotionIdNumbers, int promoPrice)
        {
            this.PromotionId = promId;
            this.PromotionIdNumbers = promotionIdNumbers;
            this.PromoPrice = promoPrice;
        }
}

