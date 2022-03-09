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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            double originalPrice,mixturePrice,profit;
            double x,totalmix;
            double milk = double.Parse(txtMilk.Text);
            originalPrice = milk * 3.25;
            x = milk / 4;
            txtMsg1.Text = "The amount of water added to the milk in liters:" + x;
            totalmix = x + milk;
            mixturePrice = totalmix * 4.15;
            profit = mixturePrice - originalPrice;
            txtMsg2.Text = "Profit amount: " + profit;


        }
    }
}