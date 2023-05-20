
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CreditCardPaymentHandler : Handler
    {
        public override void Handle(Product product)
        {
            var debibCardSystem = new CreditCardPaymentSystem();
            if (debibCardSystem.CanPayCreditCard(product.Cost))
            {
                debibCardSystem.PayFromCreditCard(product.Cost);
                product.HandledBy = "Handled By Credit Card Payment Handler !";

                return;
            }

            product.HandledBy = "Not able to handle the request !";
        }
    }
}
