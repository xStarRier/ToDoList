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
            RgbMenuItem();
            Console.WriteLine("q. Exit");
            Console.WriteLine("-----------------------");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1": 
                    ViewTasksMenu();
                    break;
                case "2":
                    DeleteTasks();
                    break;
                case "3":
                    AddTasks();
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
    public void DeleteTasks()
    {
        Console.Clear();
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Id}.) {task.TaskName}");
        }
        Console.WriteLine("Which task would you like to delete?");
        int input = Convert.ToInt32(Console.ReadLine()) - 1;
        tasks.RemoveAt(input);
        Console.WriteLine("Click any key to see the remaining tasks");
        Console.ReadKey();
        ViewTasksMenu();

    }

    public void AddTasks()
    {
       int id = tasks.Count + 1;
       Console.WriteLine("Name");
       var name = Console.ReadLine();
       Console.WriteLine("Description");
       var description = Console.ReadLine();
       Console.WriteLine("Catagory");
       var catagory = Console.ReadLine();
       Console.WriteLine("Priority");
       var priority = Console.ReadLine();
       Console.WriteLine("Status");
       var status = Console.ReadLine();
       tasks.Add(new Task(id,name,description,catagory,priority,status));
       Console.WriteLine("See all tasks");
       Console.ReadKey();
       ViewTasksMenu();
    }
    public void LightShow()
    {
        Console.Clear();
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        for (int i = 0; i < 1000; i++)
        {
            Console.Clear();
            Random rnd = new Random();
            Console.BackgroundColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(0, consoleColors.Length));
            Thread.Sleep(100);
        }
        Console.ReadKey();
        Console.ResetColor();
    }

    public void RgbMenuItem()
    {
         var consoleColors = Enum.GetValues(typeof(ConsoleColor));
         for (int i = 0; i < 60; i++)
         {
             Random rnd = new Random();
             Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(0, consoleColors.Length));
             Console.SetCursorPosition(0, Console.CursorTop);
             Console.WriteLine("4.) Break Time (illegal activity) ");     
             Console.SetCursorPosition(0, Console.CursorTop - 1);
             Thread.Sleep(50);
             
         }
         Console.WriteLine();
         Console.ResetColor();
    }
}