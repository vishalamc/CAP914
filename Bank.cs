using System;

namespace MyNewMobileApp
{
    class Bank
    {
        static double balanceAmount=1000;
        public double checkbalance()
        {
     
         return balanceAmount;
        }
        public double deposit(double depositamount)
        {
            balanceAmount = balanceAmount + depositamount;
            return balanceAmount;
        }
        public double withdrawal(double withdrawalamount)
        {
            if(withdrawalamount<balanceAmount)
            {
                balanceAmount = balanceAmount - withdrawalamount;
            }
          
            return balanceAmount;
        }
    }
}
