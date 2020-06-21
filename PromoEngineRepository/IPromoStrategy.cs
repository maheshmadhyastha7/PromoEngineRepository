using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngineRepository
{
    public interface IPromoStrategy
    {
        int ApplyPromotionCode(List<string> orders);
    }
}
