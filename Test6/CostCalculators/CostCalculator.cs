using System.Collections.Generic;

namespace Decorator
{
    public class CostCalculator : ICostCalculator
    {
        // returns the cost in base dollar ($) currency
        public double GetTotalCost(List<OrderDto> orders)
        {
            double total = 0;
            foreach (OrderDto order in orders)
            {
                total += (order.Quantity * order.Price);
            }
            return total;
        }
    }
}
