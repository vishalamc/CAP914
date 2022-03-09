using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }
       public void btnsubmit(object sender,EventArgs args)
        {
            double monthlySales,monthlyIncome;
            monthlySales = double.Parse(txtMonthlySales.Text);
            if (monthlySales >= 50000)
            {
                monthlyIncome = 375 + (0.16*monthlySales);
                lblmsg.Text = "Total Monthly sale income of a person is " + monthlyIncome;
            }
            else if (monthlySales < 50000 && monthlySales >= 40000)
            {
                monthlyIncome = 370 + (0.14 * monthlySales);
                lblmsg.Text = "Total Monthly sale income of a person is " + monthlyIncome;
            }
            else if (monthlySales < 40000 && monthlySales >= 30000)
            {
                monthlyIncome = 325 + (0.12 * monthlySales);
                lblmsg.Text = "Total Monthly sale income of a person is " + monthlyIncome;
            }
            else
if (monthlySales < 30000 && monthlySales >= 20000)
            {
                monthlyIncome = 300 + (0.09 * monthlySales);
                lblmsg.Text = "Total Monthly sale income of a person is " + monthlyIncome;
            }
            else
if (monthlySales < 20000 && monthlySales >= 10000)
            {
                monthlyIncome = 250 + (0.05 * monthlySales);
                lblmsg.Text = "Total Monthly sale income of a person is " + monthlyIncome;
            }
        }
            }
}