using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngineRepository
{
    public class PromotionOnA : IPromoStrategy
    {
        public int ApplyPromotionCode(List<string> orders)
        {
            int totalValue = 0;
            foreach (var order in orders)
            {
                var orderItems = order.Split('*');
                if (orderItems[1] == "A")
                {
                    int quotient = (int.Parse(orderItems[0])) / 3;
                    int reminder = (int.Parse(orderItems[0])) % 3;
                    var result = (quotient * 130) + (reminder * 50);
                    totalValue += result;
                }
                else if (orderItems[1] == "B")
                {
                    totalValue += int.Parse(orderItems[0]) * 30;
                }
                else if (orderItems[1]=="C")
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
