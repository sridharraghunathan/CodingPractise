
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DebitCardPaymentHandler : Handler
    {
        public override void Handle(Product product)
        {
            var debibCardSystem = new DebitCardPaymentSystem();
            if (debibCardSystem.CanPayDebitCard(product.Cost))
            {
                debibCardSystem.PayFromDebitCard(product.Cost);
                product.HandledBy = "Handled By Debit Card Payment Handler !";

                return;
            }

            base.Handle(product);
        }
    }
}
