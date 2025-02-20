using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddStudent_Clicked(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Surname = Surname.Text;
            student.Name = Name.Text;
            student.Sex = Sex.SelectedItem.ToString();
            student.Group = Group.Text;
            student.Cource = Cource.Text;

            App.Database.SaveItem(student);
        }

        private void ShowStudent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentList());
        }
    }
}
