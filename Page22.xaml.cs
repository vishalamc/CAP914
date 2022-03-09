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
    public partial class Page22 : ContentPage
    {
        public Page22()
        {
            InitializeComponent();
        }
        DateTime dt = new DateTime();
        public void ondateSelected(object sender,DateChangedEventArgs e)
        {
            dt = e.NewDate.Date;
        }
        public void btnSubmit(object sender, EventArgs ar)
        {
            var dateDiff = dt - DateTime.Now.Date;
            lblmsg.Text ="Date Difference(No.of days)" +dateDiff.Days.ToString();

        }
    }
}