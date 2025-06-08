using System;
using System.Collections.Generic; 
namespace slutprojektfinal;

public class TodoItem
{
    public string title;
    public string description;
    public string deadline;
    public string priority; // 1 = Hög, 2 = Medel, 3 = Låg

    public static TodoItem NyUppgift(TodoManager manager)
    {
        Console.WriteLine("Vad ska den kallas(Titel)?");
        string titel = Console.ReadLine();
        Console.WriteLine("Anteckningar till " + titel);
        string anteckningar = Console.ReadLine();
        Console.WriteLine("Slutdatum till " + titel + (" (yyyymmdd)"));
        string slutdatum = Console.ReadLine();
        Console.WriteLine("Prioritet (1, 2, 3) där 1 är högst");
        string prioritet = Console.ReadLine();

        TodoItem todoItem = new TodoItem();
        todoItem.title = titel;
        todoItem.deadline = slutdatum;
        todoItem.description = anteckningar;
        todoItem.priority = prioritet;

        manager.AddItem(todoItem);
        
        return todoItem;
    }
}


            
