using SimpleToDoWebApp.Frontend.Models;

namespace SimpleToDoWebApp.Frontend.Clients;

public class ToDosClient
{
    private readonly List<ToDoItem> tasks =
        [
            new ToDoItem { Name = "Task 1", DueDate = DateTime.Now, Priority = 1 },
            new ToDoItem { Name = "Task 2", DueDate = DateTime.Now, Priority = 2 },
            new ToDoItem { Name = "Task 3", DueDate = DateTime.Now, Priority = 3 },
            new ToDoItem { Name = "Task 4", DueDate = DateTime.Now, Priority = 4 },
            new ToDoItem { Name = "Task 5", DueDate = DateTime.Now, Priority = 5 }
        ];

    public List<ToDoItem> GetTasks() => tasks;
}
