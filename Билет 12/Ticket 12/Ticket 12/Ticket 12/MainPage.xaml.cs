using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void submitRating_Clicked(object sender, EventArgs e)
        {
            DisplayAlert($"Отзыв отправлен", $"Отзыв на  {servicePicker.SelectedItem} : {Math.Round(ratingSlider.Value,1)}", "Ok");
            result.Text += $"Отзыв на  {servicePicker.SelectedItem} : {Math.Round(ratingSlider.Value,1)}\n";
        }

        private void ratingSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ratingCount.Text = e.NewValue.ToString();
        }
    }
}
