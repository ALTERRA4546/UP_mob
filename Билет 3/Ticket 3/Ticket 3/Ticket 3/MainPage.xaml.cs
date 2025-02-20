using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Ticket_3.MainPage;

namespace Ticket_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            items.Add(new Item() { image = ImageSource.FromResource("Ticket_3.Res.1.png"), text = "Item 1" });
            items.Add(new Item() { image = ImageSource.FromResource("Ticket_3.Res.1.png"), text = "Item 1" });
            items.Add(new Item() { image = ImageSource.FromResource("Ticket_3.Res.1.png"), text = "Item 1" });
            items.Add(new Item() { image = ImageSource.FromResource("Ticket_3.Res.1.png"), text = "Item 1" });


            myList.ItemsSource = items;
        }

        public class Item
        {
            public ImageSource image { get; set; }
            public string text { get; set; }
        }

        List<Item> items = new List<Item>();

        
            
    }
}
