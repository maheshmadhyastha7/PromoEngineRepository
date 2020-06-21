using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngineRepository
{
    public class PromotionOnCAndD : IPromoStrategy
    {
        public int ApplyPromotionCode(List<string> orders)
        {
            int quantityOfC = 0;
            int quantityOfD = 0;
            int totalValue = 0;
            foreach (var order in orders)
            {
                var orderItems = order.Split('*');
                if (orderItems[1] == "A")
                {
                    totalValue += int.Parse(orderItems[0]) * 50;
                }
                else if (orderItems[1] == "B")
                {
                    totalValue += int.Parse(orderItems[0]) * 30;
                }
                else if (orderItems[1] == "C")
                {
                    quantityOfC = int.Parse(orderItems[0]);
                }
                else
                {
                    quantityOfD = int.Parse(orderItems[0]);
                }

            }
            if (quantityOfC == quantityOfD)
                totalValue += quantityOfC * 30;

            return totalValue;
        }
    }
}
