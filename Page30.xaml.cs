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
    public partial class Page30 : ContentPage
    {
        public Page30()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {

            base.OnAppearing();
            await progressbar1.ProgressTo(1, 10000, Easing.Linear);
            
        }
        public async void btnshow(object sender, EventArgs args)
        {
                progressbar1.IsVisible = true;
                progressbar1.Progress = 0;
                double x= 0.0;
            for (x = 0.0; x < 1.0; x++)
            {
                
                img1.IsVisible = true;
                if (x > 0 && x < 0.20)
                {
                    await progressbar1.ProgressTo(x, 30000, Easing.Linear);
                    img1.Source = "movie1.jpg";
                }
                if (x > 0.20 && x < 0.30)
                {
                    await progressbar1.ProgressTo(x, 30000, Easing.Linear);
                    img1.Source = "movie2.jpg";
                }
                if (x > 0.30 && x < 0.50)
                {
                    await progressbar1.ProgressTo(x, 30000, Easing.Linear);
                    img1.Source = "movie3.jpg";
                }
                if (x > 0.50 && x < 0.70)
                {
                    await progressbar1.ProgressTo(x, 30000, Easing.Linear);
                    img1.Source = "movie3.jpg";
                }
            }
        }
        }
    }