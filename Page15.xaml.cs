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
    public partial class Page15 : ContentPage
    {
        public Page15()
        {
            InitializeComponent();
        }
        async public void btnCGPA(object sender, EventArgs args)
        {
            string strName = txtStudentName.Text;
            int reg = int.Parse(txtRegNo.Text);
            double CAMarks = double.Parse(txtCAmarks.Text);
            double MTEMarks = double.Parse(txtMTEmarks.Text);
            double ETEMarks = double.Parse(txtETEmarks.Text);
            double attendanceMarks = double.Parse(txtAttendancemarks.Text);
            Student s1 = new Student();
            double cgpa;
            cgpa = s1.CGPAmarks(CAMarks, MTEMarks, ETEMarks, attendanceMarks);
            string result = "StudentName" + strName + System.Environment.NewLine + "regno" + reg.ToString() + System.Environment.NewLine + "cgppa" + cgpa.ToString();
            //await DisplayAlert("Result", result, "OK");
            lblresult1.Text = result;

        }
    }
}