using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewMobileApp
{
    class employee
    {

        public int empid;
        public string empname;

        public void setId(int id)
        {
            empid = id;
        }
        public void setName(string name)
        {
            empname = name;
        }
        public int getId()
        {
            return empid;
        }
        public string getName()
        {
            return empname;
        }
    }
}
