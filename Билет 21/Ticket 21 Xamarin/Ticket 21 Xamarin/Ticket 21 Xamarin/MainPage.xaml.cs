using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_21_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public class ColorItem
        { 
            public Color Color { get; set; }
            public string ColorName { get; set; }
        }

        List<ColorItem> colors = new List<ColorItem>();

        public MainPage()
        {
            InitializeComponent();

            colors.Add(new ColorItem() { Color = Color.AliceBlue, ColorName = "Alice Blue" });
            colors.Add(new ColorItem() { Color = Color.AntiqueWhite, ColorName = "Antique White" });
            colors.Add(new ColorItem() { Color = Color.Aqua, ColorName = "Aqua" });

            myList.ItemsSource = colors;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var item = e.SelectedItem as ColorItem;

            MainBackground.BackgroundColor = item.Color;
        }
    }
}
