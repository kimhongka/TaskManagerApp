using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TaskManagerApp.Interfaces;

namespace TaskManagerApp
{
    public class TaskModel : ITask
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int TaskType { get; set; }
        public string Title { get; set; }
        public Guid TaskKey { get; set; }
        public string Description { get; set; }


    }
}
