using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TaskManagerApp.Pages
{
    public partial class HomeTaskPage : ContentPage
    {
        public HomeTaskPage()
        {
            InitializeComponent();
            var allTasks = App.Database.GetItems();

            if (allTasks.Count() <= 0)
                App.Database.SaveItem(new TaskModel { TaskKey=Guid.NewGuid(), TaskType =1, Title="default title", Description="default desc" });

            HomeTaskList.ItemsSource = App.Database.GetItems().Where(i => i.TaskType == TaskListPageViewModel.HomeTaskType);
                //TaskListPageViewModel.DefaultTaskList.Where(i=>i.TaskType == TaskListPageViewModel.HomeTaskType);
        }

        void homeTaskListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var todoItem = (TaskModel)e.SelectedItem;
            var taskDetailPage = new TaskDetailPage();
            taskDetailPage.BindingContext = todoItem;

            //((App)App.Current).ResumeAtTodoId = todoItem.ID;

            Navigation.PushAsync(taskDetailPage);
        }


    }
}
