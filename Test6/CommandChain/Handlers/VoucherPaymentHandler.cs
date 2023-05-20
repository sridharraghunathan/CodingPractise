
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class VoucherPaymentHandler : Handler
    {
        public override void Handle(Product product)
        {
            var voucherPayment = new VoucherPaymentSystem();

            var _remainingAmount = voucherPayment.PayFromVoucher(product.Cost);
            if (_remainingAmount <= 0)
            {
                product.HandledBy = "Handled By Voucher Payment Handler !";
                return;
            }

            product.Cost = _remainingAmount;
            base.Handle(product);
        }
    }
}
