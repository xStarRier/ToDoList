using System.Drawing;
using System.Xml.Schema;

namespace ToDoList;

public class ToDoApp
{
    public List<Task> tasks = new List<Task>()
        {
            new Task(
                1,
                "Rydde",
                "Putte ting der de skal være",
                "Hjem",
                "Viktig",
                "Ikke gjort"
            ),
            new Task(
                2,
                "Kode",
                "Skrive kule program",
                "Jobb",
                "Viktig",
                "Ikke gjort"
            ),
    
        };
    public void Menu()
    {
        
        var isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.) View tasks");
            Console.WriteLine("2.) Delete task");
            Console.WriteLine("3.) Add a new task");
            Console.WriteLine("4.) Don't choose this");
            Console.WriteLine("q. Exit");
            Console.WriteLine("-----------------------");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1": 
                    ViewTasksMenu();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    LightShow();
                    break;
                case "q" or "Q":
                    isRunning = false;
                    break;
            }
        }
    }
    public void ViewTasksMenu()
    {
        Console.Clear();
        foreach (var task in tasks) 
        { 
            Console.WriteLine($"{task.Id}.) {task.TaskName}");
        }
        int input = Convert.ToInt32(Console.ReadLine()) - 1;
        ViewTasks(input);
    }

    public void ViewTasks(int input)
    {
        Console.Clear();
        var task = tasks[input];
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Navn: {task.TaskName}\nBeskrivelse: {task.TaskDescription}\nKategori: {task.TaskCategory}\nPrioritet: {task.TaskPriority}\nStatus: {task.TaskStatus}");
        Console.WriteLine("-----------------------");
        Console.ReadKey();
    }

    public void LightShow()
    {
        Console.Clear();
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        for (int i = 0; i < 100; i++)
        {
            Console.Clear();
            Random rnd = new Random();
            Console.BackgroundColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(0, consoleColors.Length));
            //Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(0, consoleColors.Length));
            //Console.WriteLine("Light show");
            Thread.Sleep(100);
        }
        Console.ReadKey();
        Console.ResetColor();
    }
}