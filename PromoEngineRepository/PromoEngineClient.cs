using System.Collections.Generic;

namespace PromoEngineRepository
{
    public class PromoEngineClient
    {

        public int ApplyPromo(string selection, List<string> orders)
        {
            PromoEngineHandler promotionHandler;
            switch (selection)
            {
                case "3 of A's for 130":
                    break;
                case "2 of B's for 45":
                    break;
                case "C & D for 30":
                    break;
                default:
                    break;
            }

            return 0;
        }
    }
}
