using System.Threading.Tasks;

namespace Tasks
{
    public class TaskService : ITaskService
    {
        public List<Task1> GetAllTask()
        {
            return TaskList.tasks;
        }
        public void CreateTask(Task1 t) 
        {
            TaskList.tasks.Add(t);
        }
        public void UpdateTask(Task1 t) 
        {
           Task1 task = TaskList.tasks.Find(x => x.Title == t.Title);
            task.Time = t.Time;
            task.Description = t.Description;
            task.Pref = t.Pref;
        }
        public void DeleteTask(string title) 
        {
            Task1 task = TaskList.tasks.Find(x => x.Title == title);
            TaskList.tasks.Remove(task);
        }
    }
}
