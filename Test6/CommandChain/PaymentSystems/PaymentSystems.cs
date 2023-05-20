using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class VoucherPaymentSystem
    {
        public int VoucherValue { get { return 1500; }}
        public int PayFromVoucher(int productCost)
        {
            return productCost - VoucherValue;
        }
    }

    public class WalletPaymentSystem
    {
        public int WalletValue { get { return 2500; } }
        public int PayFromWallet(int productCost)
        {
            return productCost - WalletValue;
        }
    }

    public class DebitCardPaymentSystem
    {
        public int DebitCardValue { get { return 40000; } }
        public bool CanPayDebitCard(int productCost)
        {
            return DebitCardValue >= productCost;
        }
        public void PayFromDebitCard(int productCost)
        {

        }
    }

    public class CreditCardPaymentSystem
    {
        public int CreditCardValue { get { return 100000; } }
        public bool CanPayCreditCard(int productCost)
        {
            return CreditCardValue >= productCost;
        }
        public void PayFromCreditCard(int productCost)
        {

        }
    }
}
