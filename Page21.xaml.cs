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
    public partial class Page21 : ContentPage
    {
        public Page21()
        {
            InitializeComponent();
        }
        DateTime dt = new DateTime();
        public void ondateselected(object sender, DateChangedEventArgs e)
        {
            
            dt=e.NewDate;//
            
            lblresult.Text = dt.ToString();
            lblresult2.Text = DateTime.Now.ToString();
            var datediff = dt.Date - DateTime.Now.Date;

            lblresult3.Text = datediff.Days.ToString();
        }
        
    }
}