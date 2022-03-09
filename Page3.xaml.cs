using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
      async public void btnSubmit(object sender, EventArgs args)
        {
            int value10 =int.Parse(txtvaluefor10.Text);
            int value5 = int.Parse(txtvaluefor5.Text);
            int value2 = int.Parse(txtvaluefor2.Text);
            int value1 = int.Parse(txtvaluefor1.Text);
            int result = (10 * value10) + (5 * value5) + (2 * value2) + (1 * value1);
            lblResult.Text ="Result:"+result.ToString();
        }
    }
}