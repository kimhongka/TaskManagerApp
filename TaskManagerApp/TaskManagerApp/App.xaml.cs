using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagerApp.Data;
using TaskManagerApp.Pages;
using Xamarin.Forms;

namespace TaskManagerApp
{
    public partial class App : Application
    {
        static TodoItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            //new TaskManagerApp.HomePage();
        }
        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase();
                }
                return database;
            }
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
