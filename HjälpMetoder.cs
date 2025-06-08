using System;

namespace slutprojektfinal;

public class HjälpMetoder
{
    static void Swap(List<TodoItem> list, int i, int j)
    {
        TodoItem temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

    public static void Sortering(List<TodoItem> todolist)
    {
        int n = todolist.Count;
        for (int i = 0; i < n - 1; i++)
        {
            int minsta = i;
            for (int j = i + 1; j < n; j++)
            {
                if (int.Parse(todolist[j].deadline) < minsta)
                {
                    minsta = j;
                }
            }
            if (minsta != i)
            {
                Swap(todolist, i, minsta);
            }
        }
    }
}
