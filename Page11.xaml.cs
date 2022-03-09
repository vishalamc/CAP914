using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page11 : ContentPage
    {
        public Page11()
        {
            InitializeComponent();
        }
        Bank b1 = new Bank();
        double balance;
        async public void btnDeposit(object sender, EventArgs args)
        {
            double amt = double.Parse(txtAmount.Text);
            balance = b1.deposit(amt);
            lblResult.Text = "After deposit balance: " + balance.ToString();
            await DisplayAlert("Total Balance", balance.ToString(), "OK");

        }
        async public void btnWithdrawal(object sender, EventArgs args)
        {
            double amt = double.Parse(txtAmount.Text);
            balance = b1.withdrawal(amt);
            lblResult.Text = "After withdrawal balance: " + balance.ToString();
            await DisplayAlert("Total Balance", balance.ToString(), "OK");
        }
        async public void btnCheckBalance(object sender, EventArgs args)
        {
            balance = b1.checkbalance();
            lblResult.Text = "Balance:" + balance.ToString();
            await DisplayAlert("Total Balance", balance.ToString(), "OK");
        }
    }
}
