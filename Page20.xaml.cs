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
    public partial class Page20 : ContentPage
    {
        public Page20()
        {
            InitializeComponent();
            
        }
        string strDate,strBook;
        DateTime dt = new DateTime();
        public void ondateselected(object sender, DateChangedEventArgs e)
        {
           dt = e.NewDate;
            txtDate.Text = strDate;
        }
        public void btnissues(object sender, EventArgs args)
        {
            strBook = txtBook.Text;
            lblmsg.Text = "Your Book: " + strBook + " has been issued on date:" + DateTime.Now.ToShortDateString();
        }
        public void btnreturn(object sender, EventArgs args)
        {
            var datediff = dt.Date - DateTime.Now.Date;
            // dt is Book return date which I have selected from DatePicker control
            int days = int.Parse(datediff.Days.ToString());
            if (days>15)
                {
                double fine = days * 5;
                lblmsg.Text = "Book Return Successfully after "+days+" days fine: " + fine+ " Rs";
                }
            else
            {
                lblmsg.Text = "Book Return Successfully fine:0";
            }
            
        }
    }
}