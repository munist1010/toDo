using System.Collections.Generic;


List<string> toDo = new List<string>();

while (true)
{
    if (toDo.Count > 0)
    {
        Console.WriteLine("Items on your to-do list: ");
        for (int i = 0; i < toDo.Count; i++)
        {
            Console.WriteLine((i + 1).ToString() + " - " + toDo[i]);
        }
        Console.WriteLine("");
    }
    Console.WriteLine("1. Add a new task");
    Console.WriteLine("2. Remove an existing task");
    Console.WriteLine("3. Exit the program");
    int choice = int.Parse(Console.ReadLine());

    if (choice == (int)userInput.NewTask)
    {
        Console.Write("Enter new task: ");
        string task = Console.ReadLine();
        toDo.Add(task);
        Console.Clear();
        Console.WriteLine("New task added!");
    }
    else if (choice == (int)(userInput.DeleteTask))
    {
        if (toDo.Count > 0)
        {
            Console.WriteLine("Enter the number of the task you wish to remove");
            for ( int i = 0;i < toDo.Count;i++)
            {
                Console.WriteLine("Task # " + (i+1).ToString() );
            }
        }
        int taskToRemove = int.Parse(Console.ReadLine());
        taskToRemove--;

        if (taskToRemove >= 0 && taskToRemove < toDo.Count)
        {
            toDo.RemoveAt(taskToRemove);
            Console.Clear();
            Console.WriteLine("Task deleted!");
            Console.WriteLine("");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Unable to remove task: invalid number");
            Console.WriteLine("");
        }
    }
    else if (choice == (int)(userInput.Exit))
    {
        break;
    }
}
enum userInput
{
    NewTask = 1,
    DeleteTask = 2,
    Exit = 3,
}