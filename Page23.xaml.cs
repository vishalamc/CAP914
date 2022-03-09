using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page23 : ContentPage
    {
        public Page23()
        {
            InitializeComponent();
        }
       static double totalprice = 0;
        public void btnsubmit(object sender, EventArgs args)
        {
      
            int qnt1;
            double price=0;
            double price2 = 0;
            if (string.IsNullOrWhiteSpace(txtquantity1.Text)||string.IsNullOrEmpty(txtquantity1.Text))
            {
                qnt1 = 0;
                price = 0;

               
            }

            else
            {
                qnt1 = int.Parse(txtquantity1.Text);

                if (qnt1 > 0)
                {
                    price = price + (qnt1 * 350);
                   // lblResult2.Text = "Total Amount: " + totalprice.ToString();
                }
            }
    
            int qnt2 = 0;
            if (string.IsNullOrWhiteSpace(txtquantity2.Text) || string.IsNullOrEmpty(txtquantity2.Text))
            {
                qnt1 = 0;
                price2 = 0;
             }
             else
            {
                qnt2 = int.Parse(txtquantity2.Text);

                if (qnt2 > 0)
                {
                    price2 = price2 + (qnt2 * 25);
                    
                }
            }
            totalprice = price + price2;
            lblResult2.Text = "Total Amount: " + totalprice.ToString();
        }
    }
    }