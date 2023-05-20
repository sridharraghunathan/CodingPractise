
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class WalletPaymentHandler : Handler
    {
        public WalletPaymentHandler()
        {
            Console.WriteLine("Wallet Payment Handler");
            Console.WriteLine();
        }

        public override void Handle(Product product)
        {
            var walletPayment = new WalletPaymentSystem();

            var _remainingAmount = walletPayment.PayFromWallet(product.Cost);
            if (_remainingAmount <= 0)
            {
                product.HandledBy = "Handled By Wallet Payment Handler !";
                return;
            }

            product.Cost = _remainingAmount;
            base.Handle(product);
        }
    }
}
