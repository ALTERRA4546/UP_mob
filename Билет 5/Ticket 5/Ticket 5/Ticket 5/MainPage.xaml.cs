using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ticket_5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Solve_Clicked(object sender, EventArgs e)
        {
            var expression = CalcEntry.Text;
            var result = EvaluateException(expression);
            CalcEntry.Text += "=" + result.ToString();
        }

        private double EvaluateException(string expression)
        { 
            var datatable = new System.Data.DataTable();
            var result = datatable.Compute(expression, string.Empty);
            return Convert.ToDouble(result);
        }
    }
}
