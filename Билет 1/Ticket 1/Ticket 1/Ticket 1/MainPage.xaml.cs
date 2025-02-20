using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddStudent_Clicked(object sender, EventArgs e)
        {
            StudentListTransfer.students.Add(new StudentListTransfer.Student() { surname = Surname.Text, name = Name.Text, patromic = Patromic.Text, group = Group.Text, cource = Cource.Text, sex = Sex.SelectedItem.ToString(), dateOfBirth = DateOfBirth.Date.ToString()});
        }

        private void ShowList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewPage1());
        }
    }
}
