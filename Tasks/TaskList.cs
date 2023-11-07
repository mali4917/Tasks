namespace Tasks
{
    public static class TaskList
    {
        public static List<Task1> tasks = new List<Task1>
        {
            new Task1(DateTime.Now,"Task1","Math homework", Preferance.max),
            new Task1(DateTime.Now,"Task2","English homework", Preferance.min),
            new Task1(DateTime.Now,"Task3","C# homework", Preferance.midium),
            new Task1(DateTime.Now,"Task4","Web api homework", Preferance.max),
        };    
        
        
    }
}
