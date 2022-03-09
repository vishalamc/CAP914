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
    public partial class Page33 : ContentPage
    {
        public Page33()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

          await  progressbar1.ProgressTo(1, 10000, Easing.Linear);
            if(progressbar1.Progress==1)
            {
                img1.IsVisible = true;
            }
          
        }
    }
}