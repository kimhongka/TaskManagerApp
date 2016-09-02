using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Pages;
using Xamarin.Forms;

namespace TaskManagerApp
{
    public partial class HomePage : ContentPage
    {
        public delegate string DelegateMethode(string message);

        public string Hello(string s)
        {
            return s + "hello";
        }

        public HomePage()
        {
            InitializeComponent();
            DelegateMethode del = Hello;
            var hongHello = del("hong");
            Message.Text = hongHello;

        }

        void OnBtnGoToNextBtn(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TaskListPage(Message.Text));
        }

        
      
        
    }
}
