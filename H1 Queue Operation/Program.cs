using System;
using System.Collections.Generic;

namespace H1_Queue_Operation
{
    public class Program
    {
        static void Main(string[] args)
        {
            QueueManager manager = new QueueManager();
            int menu = 0;
            do
            {
                switch (menu)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine
                        (
                         "============================================\n" +
                         "         H1 Queue Operation Menu           \n" +
                        "============================================\n" +
                        "\n1. Add item" +
                        "\n2. Delete items " +
                        "\n3. Show the number of items" +
                        "\n4. Show min and max items " +
                        "\n5. Find an item " +
                        "\n6. Print all items" +
                        "\n7. Exit \n" +
                        "\nEnter your choice"
                        );
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("What is your name");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is your age");
                        int age = int.Parse(Console.ReadLine());
                        manager.AddItems(name,age);
                        Console.WriteLine(name, age +" Has been added to the queue");
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("1 item has been dequeued");
                        manager.DeleteItems();
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("All items in queue: ");
                        Console.WriteLine(manager.ShowNumItem()); 
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(manager.ShowMinMax()); 
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Put in the name you want to look for");
                        string search = Console.ReadLine();
                        Console.WriteLine(manager.FindItem(search)); 
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(manager.AllItems());
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;


                }
            } while (menu != 7);
        }
    }
}
