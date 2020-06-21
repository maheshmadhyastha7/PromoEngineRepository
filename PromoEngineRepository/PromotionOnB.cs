using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngineRepository
{
    public class PromotionOnB : IPromoStrategy
    {
        public int ApplyPromotionCode(List<string> orders)
        {
            int totalValue = 0;
            foreach (var order in orders)
            {
                var orderItems = order.Split('*');
                if (orderItems[1] == "B")
                {
                    int q = (int.Parse(orderItems[0])) / 2;
                    int rem = (int.Parse(orderItems[0])) % 2;
                    var res = (q * 45) + (rem * 30);
                    totalValue += res;
                }
                else if (orderItems[1] == "A")
                {
                    totalValue += int.Parse(orderItems[0]) * 50;
                }
                else if (orderItems[1] == "C")
                {
                    totalValue += int.Parse(orderItems[0]) * 20;
                }
                else
                {
                    totalValue += int.Parse(orderItems[0]) * 15;
                }

            }

            return totalValue;
        }
    }
}
