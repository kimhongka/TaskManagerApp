using System;

namespace TaskManagerApp.Interfaces
{
    public interface ITask
    {
        int Id { get; set; }
        int TaskType { get; set; }
        string Title { get; set; }
        Guid TaskKey { get; set; }
        string Description { get; set; }
    }
}
