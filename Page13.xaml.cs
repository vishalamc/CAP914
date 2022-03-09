using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNewMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page13 : ContentPage
    {
        string strdate;
        public Page13()
        {
            InitializeComponent();
        }
        public void onDateSelected(object sender,DateChangedEventArgs e)
        {

            strdate = e.NewDate.ToShortDateString();
        }
        public void btnSubmit(object sender, EventArgs args)
        {
            string strName = txtName.Text;
            string strAge = txtAge.Text;
            string strPh = txtPhno.Text;
            lblName.Text = "Name: " + strName;
            lblAge.Text = "Age: " + strAge;
            lblPh.Text = "Ph No.: " + strPh;
            lblDate.Text ="Appointment Date: "+ strdate;
            lblTime.Text ="Time: "+ ddtime.Time.ToString(@"hh\:mm\:ss");
           // lblID.Text=strPh+ ddtime.Time.ToString(@"hhmmss");
           lblID.Text= "Appointment Id: "+ DateTime.Now.ToString("MdyyyyHHmmss", CultureInfo.InvariantCulture);
        }
    }
}