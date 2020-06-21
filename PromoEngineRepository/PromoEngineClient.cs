using System.Collections.Generic;

namespace PromoEngineRepository
{
    public class PromoEngineClient
    {

        public int ApplyPromo(string selection, List<string> orders)
        {
            PromoEngineHandler promoHandler;
            switch (selection)
            {
                case "3 of A's for 130":
                    promoHandler = new PromoEngineHandler(new PromotionOnA());
                    return promoHandler.ApplyPromotionCode(orders);
                case "2 of B's for 45":
                    promoHandler = new PromoEngineHandler(new PromotionOnB());
                    return promoHandler.ApplyPromotionCode(orders);
                case "C & D for 30":
                    promoHandler = new PromoEngineHandler(new PromotionOnCAndD());
                    return promoHandler.ApplyPromotionCode(orders);
                default:
                    break;
            }

            return 0;
        }
    }
}
