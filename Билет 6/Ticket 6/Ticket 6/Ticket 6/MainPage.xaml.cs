using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void solve_Clicked(object sender, EventArgs e)
        {
            double fr = double.Parse(first.Text);
            double tw = double.Parse(two.Text);

            switch(operand.SelectedItem)
                {
                case "+":
                    result.Text = (fr + tw).ToString();
                    break;

                case "-":
                    result.Text = (fr - tw).ToString();
                    break;

                case "*":
                    result.Text = (fr * tw).ToString();
                    break;

                case "/":
                    result.Text = (fr / tw).ToString();
                    break;
            }
        }
    }
}
