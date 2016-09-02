using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    public class TaskListPageViewModel 
    {
        public const int HomeTaskType = 1;
        public const int WorkTaskType = 2;
         
        public string TaskListTitle { get; set; }
        public List<TaskModel> Tasks { get; set; }
        public static IList<TaskModel> DefaultTaskList { set; get; }

        static TaskListPageViewModel()
        {
            DefaultTaskList =
                new ObservableCollection<TaskModel> {
                new TaskModel {
                    Id = 1,
                    TaskType = 1,
                    Title = "Dish",
                    TaskKey = Guid.NewGuid(),
                    Description = "wash wash wash",

                },
                 new TaskModel {
                    Id = 2,
                    TaskType = 2,
                    Title = "Big work",
                    TaskKey = Guid.NewGuid(),
                    Description = "clean clean",

                }
            };
        }

    }
}
