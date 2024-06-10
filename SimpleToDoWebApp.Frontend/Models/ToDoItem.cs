namespace SimpleToDoWebApp.Frontend.Models;

public class ToDoItem
{
        public string Name { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
}
