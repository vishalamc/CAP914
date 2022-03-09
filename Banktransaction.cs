using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewMobileApp
{
    class Banktransaction
    {
        static double balance=1000;
               
        public double withdrawal(double withdrawalamount)
        {
            if(withdrawalamount<balance)
            {
                balance = balance - withdrawalamount;
            }
            return balance;
        }
        public double deposit(double depositamount)
        {
            balance = balance + depositamount;
            return balance;
        }
        public double checkBalance()
        {
            return balance;
        }
    }
}
