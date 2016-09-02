using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TaskManagerApp.Pages
{
    public partial class TaskListPage : TabbedPage
    {
        public TaskListPage()
        {
            InitializeComponent();
        }

        public TaskListPage(string taskListTitle)
        {
            //var navigationPage = new NavigationPage();
            Children.Add(new HomeTaskPage());
            Children.Add(new WorkTaskPage());
        }

    }
}
