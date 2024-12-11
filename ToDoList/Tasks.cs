namespace ToDoList;

public class Task
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public string TaskDescription { get; set; } 
    public string TaskCategory { get; set; }
    public string TaskPriority { get; set; }
    public string TaskStatus  { get; set; }

    public Task(int id,string taskName, string taskDescription, string taskCategory, string taskPriority, string taskStatus)
    {
        Id = id;
        TaskName = taskName;
        TaskDescription = taskDescription;
        TaskCategory = taskCategory;
        TaskPriority = taskPriority;
        TaskStatus = taskStatus;
    }


    
    
    

}


