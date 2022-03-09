using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page17 : ContentPage
    {
        public Page17()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            int product = int.Parse(txtProduct.Text);
            double result;
            Product p1 = new Product();
            result = p1.getCommision(product);
            lblResult.Text = result.ToString();
        }
    }
}