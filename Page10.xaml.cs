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
    public partial class Page10 : ContentPage
    {
        static double amt;
        public Page10()
        {
            InitializeComponent();
        }
        public void btndeposit(object sender, EventArgs args)
        {
            amt = double.Parse(txtAmount.Text);
            Banktransaction b1 = new Banktransaction();
            double udpatedBalance= b1.deposit(amt);
            lblResult.Text ="Balance after deposit: "+ udpatedBalance.ToString();
        }
        public void btnwithdrawal(object sender, EventArgs args)
        {
            amt = double.Parse(txtAmount.Text);
            Banktransaction b1 = new Banktransaction();
            double udpatedBalance = b1.withdrawal(amt);
            lblResult.Text = "Balance after withdrawal: "+udpatedBalance.ToString();
        }
        public void btncheckbalance(object sender, EventArgs args)
        {
            Banktransaction b1 = new Banktransaction();
            double udpatedBalance = b1.checkBalance();
            lblResult.Text = "Balance: " + udpatedBalance.ToString();
        }

    }
}