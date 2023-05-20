using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public class SalesTaxDecorator : CostCalculatorBaseDecorator
    {
        private readonly double _taxRate;

        public SalesTaxDecorator(double taxRate, ICostCalculator costCalculator)
            : base(costCalculator)
        {
            _taxRate = taxRate;
        }

        public override double GetTotalCost(List<OrderDto> orders)
        {
            double cost =
                base.GetTotalCost(orders);
            return cost * _taxRate;
        }
    }
}
