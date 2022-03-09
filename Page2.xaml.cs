using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
         async void btnsubmit(object sender,EventArgs args)
        {
            Student s1 = new Student();
            
            double result;
         int unit=int.Parse(txtunit.Text);
           if(unit>100) 
            {
                int actualunit = unit - 100;
                result =(100*5.95)+(actualunit * 6.95);

            }
           else 
            {
                result = unit * 5.95;
            }
            lblmsg.Text ="You have to pay: "+ result.ToString();
        }


    }
}