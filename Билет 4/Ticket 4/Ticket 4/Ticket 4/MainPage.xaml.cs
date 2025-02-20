using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddEmployee_Clicked(object sender, EventArgs e)
        {
            StoredData.employees.Add(new StoredData.Employee() { SurnameNamePatromyc = Surname.Text+ "." + Name.Text[0]+ "." + Patromic.Text[0]+ ".", DateOfBirth = (DateTime.Now.Year - DateOfBirth.Date.Year).ToString(), City = City.SelectedItem.ToString() });
        }

        private void ShowEmployee_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EmployeeList());
        }
    }
}
