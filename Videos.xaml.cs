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
    public partial class Videos : ContentPage
    {
        public Videos(string song)
        {
            InitializeComponent();

            if(song.Equals("hindi"))
            {
                songswebview.Source = "https://www.youtube.com/watch?v=Ep1UB12YkzI";
            }
            if (song.Equals("telugu"))
            {
                songswebview.Source = "https://www.youtube.com/watch?v=Ep1UB12YkzI";
            }
            if (song.Equals("tamil"))
            {
                songswebview.Source = "https://www.youtube.com/watch?v=Ep1UB12YkzI";
            }
            if (song.Equals("punjabi"))
            {
                songswebview.Source = "https://www.youtube.com/watch?v=Ep1UB12YkzI";
            }
        }
    }
}