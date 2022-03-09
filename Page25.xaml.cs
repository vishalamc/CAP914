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
    public partial class Page25 : ContentPage
    {
        public Page25()
        {
            InitializeComponent();
        }
        public void onvaluechanged(object sender,ValueChangedEventArgs a)
        {
            double range = a.NewValue;
            if(range>0 && range<10000)
            {
                img1.IsVisible = true;
            }
            if (range > 10000 && range < 15000)
            {
                img2.IsVisible = true;
            }
            if (range > 15000 && range < 20000)
            {
                img1.IsVisible = true;
            }
        }
    }
}