using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page19 : ContentPage
    {
        public Page19()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            int i;
            string []myArray = new string[5] { "Ibrahim", "Rahul", "Shivam", "Aman", "Aryan" };
            for(i=0;i<5;i++)
            {
               lblElement.Text += myArray[i] + " ";
            }
        }
    }
}