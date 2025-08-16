using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tempTaskmanage.Model;

namespace tempTaskmanage.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TaskConreollarController : ControllerBase
    {
        private List<TaskItem> _tasks = new List<TaskItem>()
        {

           new TaskItem {Id=1, Title="Task1", Description="Welcome to our "},
           new TaskItem {Id=2, Title="Task2", Description="Welcome to our "},
};
   

        //GET
        [HttpGet("getall")]
        public ActionResult GetTask()
        {
            if (_tasks.Count == 0)
            {
                return NotFound("No task found");
            }
            return Ok(_tasks);
        }
        //POST
        [HttpPost("create")]
        public ActionResult CreateTask([FromBody] TaskItem task)
        { 
            if (task== null || string.IsNullOrEmpty(task.Title))
            {
                return BadRequest("Invalid");
            }
            return Ok(_tasks);
        }  
    }        
}
