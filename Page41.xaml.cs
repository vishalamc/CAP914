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
    public partial class Page41 : ContentPage
    {
        public Page41()
        {
            InitializeComponent();
        }
        async public void btnHindiSongs(object sender, EventArgs args)
        {
            
            await Navigation.PushAsync(new Videos("hindi"));
        }
        async public void btnTeluguSongs(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new Videos("telugu"));
        }
        async public void btnTamilSongs(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new Videos("tamil"));
        }
        async public void btnPunjabiSongs(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new Videos("punjabi"));
        }
    }
}