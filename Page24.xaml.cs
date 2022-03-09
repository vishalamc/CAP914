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
    public partial class Page24 : ContentPage
    {
        public Page24()
        {
            InitializeComponent();
            img1.IsVisible = false;
        }
       int range;
        public void onstepperclick(object sender, ValueChangedEventArgs ar)
        {
            lbl1.Text += "*";
            range =int.Parse(ar.NewValue.ToString());
            int i;
            for(i=0;i<range; i++)
            {
                lbl1.Text += "*";
               // lbl1.TextColor = Color.Red;
            }
            

            lblrate.Text = ar.NewValue.ToString();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            img1.IsVisible = true;
            lblMsg.Text = txtEditor.Text;
            lblName.Text ="Posted By: "+ txtName.Text;
            lblDate.Text = "Posted on: " + DateTime.Now.ToShortDateString();

        }
    }
}