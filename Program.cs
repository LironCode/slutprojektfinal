using slutprojektfinal;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Välkommen. Vad vill du göra?");
HjälpMetoder metoder = new HjälpMetoder();
TodoManager manager = new TodoManager();
List<TodoItem> tasks = manager.GetTodoList();

for (int x = 1; x < 10; x--)
{
    Console.WriteLine("ny uppgift | radera uppgift | sortera | skriv ut | avsluta");
    string svar1 = Console.ReadLine();

    if (svar1 == "avsluta")
    {
        break;
    }
    else
    {
        switch (svar1)
        {
            case "ny uppgift":
                TodoItem.NyUppgift(manager);
                break;
            case "radera uppgift":
                Console.WriteLine("Vilken uppgift vill du radera? (ange nummer)");

                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i}: {tasks[i].title}");
                }

                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < tasks.Count)
                {
                    manager.DeleteItem(tasks[index]);
                    Console.WriteLine("Uppgiften har raderats.");
                }
    else
    {
        Console.WriteLine("Ogiltigt nummer.");
    }
                break;
            case "sortera":
                Console.WriteLine("Sorterar efter datum: ");
                HjälpMetoder.Sortering(manager.GetTodoList());
                foreach (TodoItem i in manager.GetTodoList())
                    {
                        Console.WriteLine(i.title + "(Deadline: " + i.deadline + ", Prioritet: " + i.priority + ", Anteckningar: " + i.description + ")");
                    }

                break;
            case "skriv ut":
                Console.WriteLine("Antal uppgifter i listan: " + tasks.Count);
                Console.WriteLine("Vill du skriva ut en enskild sak eller hela todolistan(enskild/lista)?");
                string enskildlista = Console.ReadLine();
                if (enskildlista == "enskild")
                {
                    Console.WriteLine("Vilken uppgift vill du skriva ut(1, 2...)?");
                    int svar2 = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Titel: " + tasks[svar2].title);
                    Console.WriteLine("Deadline: " + tasks[svar2].deadline);
                    Console.WriteLine("Anteckningar: " + tasks[svar2].description);
                    Console.WriteLine("Prioritet: " + tasks[svar2].priority);
                }
                else if (enskildlista == "lista")
                {
                    foreach (TodoItem i in tasks)
                    {
                        Console.WriteLine(i.title + "(Prioritet: " + i.priority + ", Deadline: " + i.deadline + ", Anteckningar: " + i.description + ")");
                    }
                }
                else
                {
                    Console.WriteLine("Något blev fel. Se till att du har skrivit rätt och försök igen");
                }
                break;

            default:
                Console.WriteLine(svar1 + " fungerar inte. Dubbelkolla att du har skrivit rätt");
                break;
        }
    }
}