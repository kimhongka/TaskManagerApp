using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Data
{
    public class TodoItemDatabase
    {
        static object locker = new object();

        SQLiteConnection database;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
        /// if the database doesn't exist, it will create the database and all the tables.
        /// </summary>
        /// <param name='path'>
        /// Path.
        /// </param>
        public TodoItemDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<TaskModel>();
        }

        public IEnumerable<TaskModel> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<TaskModel>() select i).ToList();
            }
        }

        public IEnumerable<TaskModel> GetItemsNotDone()
        {
            lock (locker)
            {
                return database.Query<TaskModel>("SELECT * FROM [TaskModel] WHERE [Done] = 0");
            }
        }

        public TaskModel GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<TaskModel>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveItem(TaskModel item)
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    database.Update(item);
                    return item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<TaskModel>(id);
            }
        }
    }
}
