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
    public partial class Page26 : ContentPage
    {
        public Page26()
        {
            InitializeComponent();
        }
        double range;
        public void btnsubmit(object sender, EventArgs args)
        {
          string str= editor1.Text;
        }
        public void onstepperclick(object sender,ValueChangedEventArgs ar)
        {
          range=  ar.NewValue;
        }
    }
}