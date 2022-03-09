using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewMobileApp
{
    class food
    {
        public bool should_serve_foods(int age, bool fasting)
        {
            bool res1=true;
            bool res2 = false;
            if (age>=18 && fasting==false)
            {
                return res1;
            }
            else
            {
                return res2;
            }
           
        }
    }
}
