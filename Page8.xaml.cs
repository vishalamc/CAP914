using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            food f1 = new food();
            bool status;
            string str = "";
            bool st=true;
            int age =int.Parse(txtAge.Text);
            str = txtFasting.Text;
            if(str.Equals("fasting"))
            {
                st = true;
            }
            if (str.Equals("not fasting"))
            {
                st = false;
            }
            else
            {
                lblmsg.Text = "Not valid input";
            }
            status = f1.should_serve_foods(age, st);
            if(status==true)
            {
                lblmsg.Text = "Food Serve";
            }
            else
            {
                lblmsg.Text = "Food Serve";
            }
            
        }

    }
}