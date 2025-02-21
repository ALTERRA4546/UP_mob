using System;
using Ticket_10_Xamarin.MVVM.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ticket_10_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MarsView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
