using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_7_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public int count = 0;

        private async void pizzaOrder_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Заказ", $"Вы выбрали {pizzaPicker.SelectedItem} в количестве {count}", "ОК");
        }

        private void pizzaCount_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            pizzaCountLabel.Text = Convert.ToInt32(e.NewValue).ToString();
            count = Convert.ToInt32(e.NewValue);
        }
    }
}
