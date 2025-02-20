using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ticket_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentList : ContentPage
    {
        public StudentList()
        {
            InitializeComponent();
        }

            

        protected override void OnAppearing()
        {
            MyListView.ItemsSource = App.database.GetItems();

            base.OnAppearing();
        }
    }
}
