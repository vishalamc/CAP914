using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page31 : ContentPage
    {
        public Page31()
        {
            InitializeComponent();
            //list1.ItemsSource = mylist;

        }
      static  List<string> mylist = new List<string>();
     
        public void btnadd(object sender, EventArgs e)
        {
            string strProduct = txtProduct.Text;
            mylist.Add(strProduct);
            list1.ItemsSource = mylist;
        }
        public void btnshow(object sender, EventArgs e)
        {
            list1.ItemsSource = mylist;
            //list1.BeginRefresh();
        }
    }
}