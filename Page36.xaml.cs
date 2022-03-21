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
    public partial class Page36 : ContentPage
    {
        public Page36()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender,EventArgs args)
        {
            Resources["style1"] = Resources["style2"];
        }
    }
}