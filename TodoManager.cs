using System;
using System.Collections.Generic; 
namespace slutprojektfinal;

public class TodoManager
{
    private List<TodoItem> todolist = new List<TodoItem> {};

    public void AddItem(TodoItem todoItem)
    {
        todolist.Add(todoItem);
    }

    public void DeleteItem(TodoItem todoItem)
    {
        todolist.Remove(todoItem);
    }
    public List<TodoItem> GetTodoList()
    {
        return todolist;
    }
}
