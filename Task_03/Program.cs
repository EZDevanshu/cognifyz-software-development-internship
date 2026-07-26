using System;
using System.Collections.Generic;
using Task_03_TaskManager;

namespace Task_03
{
    internal class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== TASK MANAGER =====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Update Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;

                    case 2:
                        ViewTasks();
                        break;

                    case 3:
                        UpdateTask();
                        break;

                    case 4:
                        DeleteTask();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        static void AddTask()
        {
            TaskItem task = new TaskItem();

            Console.Write("Enter Id: ");
            task.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Title: ");
            task.Title = Console.ReadLine();

            Console.Write("Enter Description: ");
            task.Description = Console.ReadLine();

            tasks.Add(task);

            Console.WriteLine("Task Added Successfully.");
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No Tasks Found.");
                return;
            }

            foreach (TaskItem task in tasks)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Id : " + task.Id);
                Console.WriteLine("Title : " + task.Title);
                Console.WriteLine("Description : " + task.Description);
            }
        }

        static void UpdateTask()
        {
            Console.Write("Enter Task Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (TaskItem task in tasks)
            {
                if (task.Id == id)
                {
                    Console.Write("New Title: ");
                    task.Title = Console.ReadLine();

                    Console.Write("New Description: ");
                    task.Description = Console.ReadLine();

                    Console.WriteLine("Task Updated.");
                    return;
                }
            }

            Console.WriteLine("Task Not Found.");
        }

        static void DeleteTask()
        {
            Console.Write("Enter Task Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            TaskItem taskToDelete = null;

            foreach (TaskItem task in tasks)
            {
                if (task.Id == id)
                {
                    taskToDelete = task;
                    break;
                }
            }

            if (taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                Console.WriteLine("Task Deleted.");
            }
            else
            {
                Console.WriteLine("Task Not Found.");
            }
        }
    }
}