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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
         public void btnsubmit(object sender,EventArgs args)
        {
            string strcolor = txtcolor.Text;
            switch(strcolor)
            {
                case "Red":
                    
                     BackgroundColor = Color.Red;
                    break;

                case "Green":
                    BackgroundColor = Color.Green;
                    break;
                case "Blue":
                    BackgroundColor = Color.Blue;
                    break;
                case "Yellow":
                    BackgroundColor = Color.Yellow;
                    break;

            }
        }
    }
}