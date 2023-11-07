using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace Tasks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;
        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet("getAllTask")]
        public List<Task1> Get()
        {
            List<Task1> tt = taskService.GetAllTask();
            return tt;
        }

        [HttpPost("createTask")]
        public void Post(Task1 t)
        {
            taskService.CreateTask(t);
        }

        [HttpPut("updateTask")]
        public void Put(Task1 t)
        {
            taskService.UpdateTask(t);
        }

        [HttpDelete("deleteTask")]
        public void Delete(string title)
        {
            taskService.DeleteTask(title);
        }

























        //private readonly ILogger<TaskController> _logger;

        //public TaskController(ILogger<TaskController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<TaskController> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new Task
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}