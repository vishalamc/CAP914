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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            /* int num1,num2;
            num1=int.Parse(txtvalue1.Text);
             num2 = int.Parse(txtvalue2.Text);
             int result = num1 + num2;
             lblresult.Text = result.ToString();
            */
            employee e1 = new employee();
            e1.getId();


        }
    }
}