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
    public partial class Page28 : ContentPage
    {
        public Page28()
        {
            InitializeComponent();
        }
        static string str1= "";
        
        public void btnslider(object sender,ValueChangedEventArgs ar)
        {
            if(ar.NewValue>0 && ar.NewValue<2)
            {
                imgmovie.Source = "movie1.jpg";
                str1= "movie1.jpg";
            }
            if (ar.NewValue > 2 && ar.NewValue < 4)
            {
                imgmovie.Source = "movie2.jpg";
                str1 = "movie2.jpg";
            }
            if (ar.NewValue > 4 && ar.NewValue < 5)
            {
                imgmovie.Source = "movie3.jpg";
                str1 = "movie3.jpg";
            }
        }
       static int rate1,rate2,rate3;
        public void btnstepper(object sender,ValueChangedEventArgs arg)
        {
          // var r = 0;
            if(str1.Equals("movie1.jpg") )
            {
                rate1 = int.Parse(arg.NewValue.ToString());
                
            }
            else if (str1.Equals("movie2.jpg"))
            {
                rate2 = int.Parse(arg.NewValue.ToString());
            }
            else if (str1.Equals("movie3.jpg"))
            {
                rate3 = int.Parse(arg.NewValue.ToString());
            }

        }
        public void btnsubmit(object sender,EventArgs args)
        {
            lblmovie.Text = "3 Idiot: " + rate1+" Sholay: " +rate2+ " Border: "+rate3;

        }
    }
}