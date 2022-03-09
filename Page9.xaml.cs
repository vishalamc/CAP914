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
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
        }
        public void btnsubmit(object sender, EventArgs args)
        {
            int eid = int.Parse(txtID.Text);
            string ename = txtName.Text;
            employee e1 = new employee();
            e1.setId(eid);
            e1.setName(ename);
            lblResult.Text = "Employee Name: " + e1.getName() + "Employee Id: " + e1.getId();
        }
        }
}