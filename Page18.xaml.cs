using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page18 : ContentPage
    {
        public Page18()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender,EventArgs args)
        {
            int a, b, i;
           
            a = int.Parse(txtValuea.Text);// starting range :2
            b = int.Parse(txtValueb.Text);// ending range: 11
            
            string[] strArray = new string[9]{ "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                //i=8;i<=11;i++
            for (i = a; i <= b; i++)
            {
                if (i <= 9)
                {
                    
                    lblResult.Text += strArray[i - 1] +" ";
                }
                else
                {

                    if (i % 2 == 0)
                    {
                        lblResult.Text += " even";
                    }
                    else
                    {
                        lblResult.Text += " odd";
                    }
                }
            }
            
        }
    }
}