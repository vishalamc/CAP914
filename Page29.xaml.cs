using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page29 : ContentPage
    {
        public Page29()
        {
            InitializeComponent();
        }
         protected override async void OnAppearing()
        {

            base.OnAppearing();
           await progressbar1.ProgressTo(1, 10000, Easing.Linear);
            
        }
            public async void btnsubmit(object sender, EventArgs args)
        {
            string struser = txtUserName.Text;
            string strpassword = txtPassword.Text;
            if(struser.Equals("user") && strpassword.Equals("user123"))
            {

                progressbar1.IsVisible = true;
                progressbar1.Progress = 0;
                await progressbar1.ProgressTo(1, 10000, Easing.Linear);
                if (int.Parse(lbl.Text) == 1)
                {
                    lblmsg.Text = "login Success";
                    img1.IsVisible = true;
                }
               

            }
            else
            {
                progressbar1.IsVisible = true;
                progressbar1.Progress = 0;
                await progressbar1.ProgressTo(1, 10000, Easing.Linear);
                lblmsg.Text = "Not Valid User";
            }

        }

    }
}