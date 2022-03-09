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
    public partial class Page12 : ContentPage
    {
        public Page12()
        {
            InitializeComponent();
        }
        async public void btnCGPA(object sender, EventArgs args)
        {
            string strName = txtStudentName.Text;
            int regno = int.Parse(txtRegNo.Text);
            double CAMarks = double.Parse(txtCAMarks.Text);
            double MTEMarks = double.Parse(txtMTEMarks.Text);
            double ETEMarks = double.Parse(txtETEMarks.Text);
            int attmarks = int.Parse(txtAttMarks.Text);
            Student s1 = new Student();
            double cgpa;
           // cgpa= s1.getCGPAMarks(CAMarks, MTEMarks, ETEMarks, attmarks);

            //await DisplayAlert("Result", strName + " " + regno.ToString() + cgpa.ToString(), "OK");
        }
    }
}