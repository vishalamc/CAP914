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
    public partial class Page34 : ContentPage
    {
        public Page34()
        {
            InitializeComponent();
            listview1.ItemsSource = list1;
        }
        public List<string> list1 = new List<string>
        {
            "MobilePhone","Laptop","HeadPhone","Charger"
        };
    }
}