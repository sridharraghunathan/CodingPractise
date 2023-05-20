using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public abstract class CostCalculatorBaseDecorator : ICostCalculator
    {
        private readonly ICostCalculator _costCalculator;

        public CostCalculatorBaseDecorator(ICostCalculator costCalculator)
        {
            _costCalculator = costCalculator;
        }
        public virtual double GetTotalCost(List<OrderDto> orders)
        {
            return _costCalculator.GetTotalCost(orders);
        }
    }
}
