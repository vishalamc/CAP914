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
    public partial class Page32 : ContentPage
    {
        public Page32()
        {
            InitializeComponent();
        }
        public List<string> list1 = new List<string>()
        {
            "CAP100","CAP101","CAP102","CAP103","CAP104","CAP105"
        };
        public void btnsearch(object sender, EventArgs args)
        {
           string key= searchbar1.Text.ToUpper();
           
            IEnumerable<string> res=list1.Where(x => x.Contains(key));
            mylistview.ItemsSource = res;

        }
    }
}