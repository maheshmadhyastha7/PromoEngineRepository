using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngineRepository
{
    public class PromoEngineHandler
    {
        private IPromoStrategy _promoStrategy;
        public PromoEngineHandler(IPromoStrategy promoStrategy)
        {
            _promoStrategy = promoStrategy;
        }
        public int ApplyPromotionCode(List<string> orders)
        => _promoStrategy.ApplyPromotionCode(orders);
    }
}
