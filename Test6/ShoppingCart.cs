using Decorator.Decorators;
using System.Collections.Generic;

namespace Decorator
{
    public class ShoppingCart 
    {
        private readonly string _countryCode;

        private List<OrderDto> OrderList { get; } = new List<OrderDto>();
        public ShoppingCart(string countryCode)
        {
            OrderList.Add(new OrderDto { OrderId = 1, Price = 20, Quantity = 2 });
            OrderList.Add(new OrderDto { OrderId = 2, Price = 10, Quantity = 3 });
            _countryCode = countryCode;
        }

        public ShoppingCartDto GetShoppingCartDetail()
        {
            ShoppingCartDto shoppingCartDto = new ShoppingCartDto
            {
                Orders = OrderList,
                TotalPrice = GetTotalPrice()
            };

            return shoppingCartDto;
        }

        private double GetTotalPrice()
        {
            ICostCalculator costCalculator = new CostCalculatorFactory().
                GetCostCalculator(_countryCode, new CostCalculator());
            return costCalculator.GetTotalCost(OrderList);
        }
    }
}
