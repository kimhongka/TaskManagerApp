using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskManagerApp
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        string message;
        public string TaskTitle { get; set; }
        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged("Message");
                }
            }
        }
        #region command

        public Command NextToTaskListPageCommand
        {
            get
            {
                return new Command(() =>
                {
                    SetNewMessage();
                });
            }
        }
        #endregion -- command list

        void SetNewMessage()
        {
            this.Message = TaskTitle;
            
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
