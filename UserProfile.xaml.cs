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
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
        }
      async  public void btnGmail(object sender, EventArgs args)
        {
            await Navigation.PushAsync( new Gamil());

        }
        async public void btnFacebook(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Facebook());
        }
        async public void btnInstagram(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Instagram());
        }
        async public void btnLinkedIn(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LinkedIn());
        }
    }
}