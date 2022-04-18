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
    public partial class WebPage : ContentPage
    {
        public WebPage()
        {
            InitializeComponent();
        }
        async public void btnUrl(object sender, EventArgs ar)
        {
            string strurl = "https://" + txtUrl.Text;
            await Navigation.PushAsync(new homeurl(strurl));
        }
    }
}