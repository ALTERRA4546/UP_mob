using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ticket_2
{
    public partial class App : Application
    {
        public const string databasename = "student.db";
        public static StudentRepository database;
        public static StudentRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new StudentRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), databasename));
                }

                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
