using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_18_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ItemData> Items {  get; set; }

        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<ItemData>()
            {
                new ItemData {Image=ImageSource.FromResource("Ticket_18_Xamarin.1.png"), Title = "Item1", Price = 10.0, Count = 0},
                new ItemData {Image=ImageSource.FromResource("Ticket_18_Xamarin.1.png"), Title = "Item1", Price = 10.0, Count = 0},
                new ItemData {Image=ImageSource.FromResource("Ticket_18_Xamarin.1.png"), Title = "Item1", Price = 10.0, Count = 0},
                new ItemData {Image=ImageSource.FromResource("Ticket_18_Xamarin.1.png"), Title = "Item1", Price = 10.0, Count = 0},
                new ItemData {Image=ImageSource.FromResource("Ticket_18_Xamarin.1.png"), Title = "Item1", Price = 10.0, Count = 0},
            };

            myList.ItemsSource = Items;
        }

        private void OnIncrementClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = (ItemData)button.CommandParameter;
            item.Count++;
        }

        private void OnDecrementClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = (ItemData)button.CommandParameter;
            item.Count--;
        }
    }
}
