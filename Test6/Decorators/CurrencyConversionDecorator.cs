using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public class CurrencyConversionDecorator : CostCalculatorBaseDecorator
    {
        private readonly Dictionary<string, double> _exchangeRate
           = new Dictionary<string, double>
           {
                { "IN", 74 },
                { "EU", .85 },
                { "PAK", 170 },
                { "CHI", 6.92 },
           };


        private readonly string _countryCode;

        public CurrencyConversionDecorator(string countryCode, ICostCalculator costCalculator)
            : base(costCalculator)
        {
            _countryCode = countryCode;
        }

        public override double GetTotalCost(List<OrderDto> orders)
        {
            return base.GetTotalCost(orders) * _exchangeRate[_countryCode];
        }
    }
}
