using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewMobileApp
{
    class Product
    {
        public double getCommision(int noOfProduct)
        {
            double amount;
            if(noOfProduct<=200)
            {
                amount = noOfProduct * 5;
            }
            else
            {
                amount = (200 * 5) + (noOfProduct - 200) * 10;
            }
            return amount;
        }
    }
}
