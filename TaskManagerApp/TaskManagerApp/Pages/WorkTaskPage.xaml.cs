using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TaskManagerApp.Pages
{
    public partial class WorkTaskPage : ContentPage
    {
        public WorkTaskPage()
        {
            InitializeComponent();
            WorkTaskList.ItemsSource = TaskListPageViewModel.DefaultTaskList.Where(i => i.TaskType == TaskListPageViewModel.WorkTaskType);

        }

    }
}
