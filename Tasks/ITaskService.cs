namespace Tasks
{
    public interface ITaskService
    {
        public List<Task1> GetAllTask();
        public void CreateTask(Task1 t);
        public void UpdateTask(Task1 t);
        public void DeleteTask(string title);
    }
}
