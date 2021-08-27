using MeDo.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeDo.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private TodoLists userLists;

        public TaskController()
        {
            var list1Tasks = new List<TodoTask>
            {
                new TodoTask(1, "Do bins"),
                new TodoTask(2, "Learn about Blazor"),
                new TodoTask(3, "Other stuff", "Some banal description")
            };
            var userFirstList = new TodoList(1, "My list", list1Tasks);


            var list2Tasks = new List<TodoTask>
            {
                new TodoTask(4, "Shave"),
                new TodoTask(5, "Do a dance"),
                new TodoTask(6, "Get down tonight", "Some banal description")
            };
            var userSecondList = new TodoList(2, "Things that might be fun", list2Tasks);

            var userInitialLists = new List<TodoList>
            {
                userFirstList,
                userSecondList
            };
            userLists = new TodoLists(1, userInitialLists);
        }


        // GET: api/<TaskController>
        [HttpGet("lists")]
        public TodoLists Get()
        {
            return userLists;
        }


        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TaskController>
        [HttpPost]
        public void Post([FromBody] TodoTask task)
        {
            var listIndex = task.Id < 4 ? 0 : 1;
            var taskIndex = userLists.Lists[listIndex].Tasks.FindIndex(_task => _task.Id.Equals(task.Id));
            userLists.Lists[listIndex].Tasks[taskIndex] = task;
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
