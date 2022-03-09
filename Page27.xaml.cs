using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page27 : ContentPage
    {
        public Page27()
        {
            InitializeComponent();
        }
        public void btnslider(object sender,ValueChangedEventArgs args)
        {
            if(args.NewValue>0 && args.NewValue<10)
            {
                box1.Color = Color.Green;
            }
            if (args.NewValue > 10 && args.NewValue < 15)
            {
                box1.Color = Color.Red;
            }
            if (args.NewValue > 15 && args.NewValue < 20)
            {
                box1.Color = Color.Purple;
            }
        }
        public void btnsteeper(object sender,ValueChangedEventArgs ar)
        {
            int rate = int.Parse(ar.NewValue.ToString());
            switch (rate)
            {
                case 0:
                    lblstar1.TextColor = Color.White;
                    lblstar2.TextColor = Color.White;
                    lblstar3.TextColor = Color.White;
                    lblstar4.TextColor = Color.White;
                    lblstar5.TextColor = Color.White;
                    break;
                case 1:
                    lblstar1.TextColor = Color.Red;
                    lblstar2.TextColor = Color.White;
                    lblstar3.TextColor = Color.White;
                    lblstar4.TextColor = Color.White;
                    lblstar5.TextColor = Color.White;
                    break;
                case 2:
                    lblstar1.TextColor = Color.Red;
                    lblstar2.TextColor = Color.Red;
                    lblstar3.TextColor = Color.White;
                    lblstar4.TextColor = Color.White;
                    lblstar5.TextColor = Color.White;
                    break;
                case 3:
                    lblstar1.TextColor = Color.Red;
                    lblstar2.TextColor = Color.Red;
                    lblstar3.TextColor = Color.Red;
                    lblstar4.TextColor = Color.White;
                    lblstar5.TextColor = Color.White;
                    break;
                case 4:
                    lblstar1.TextColor = Color.Red;
                    lblstar2.TextColor = Color.Red;
                    lblstar3.TextColor = Color.Red;
                    lblstar4.TextColor = Color.Red;
                    lblstar5.TextColor = Color.White;
                    break;
                case 5:
                    lblstar1.TextColor = Color.Red;
                    lblstar2.TextColor = Color.Red;
                    lblstar3.TextColor = Color.Red;
                    lblstar4.TextColor = Color.Red;
                    lblstar5.TextColor = Color.Red;
                    break;
                default:
                    lblstar1.TextColor = Color.White;
                    lblstar2.TextColor = Color.White;
                    lblstar3.TextColor = Color.White;
                    lblstar4.TextColor = Color.White;
                    lblstar5.TextColor = Color.White;
                    break;
            }
        }
    }
}