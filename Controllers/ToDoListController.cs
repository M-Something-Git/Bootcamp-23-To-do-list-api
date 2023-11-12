using Bootcamp_23_todo_list_api.Models;
using Bootcamp_23_todo_list_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_23_todo_list_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListService _toDoListService;
        public ToDoListController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }
       
        [HttpGet]
        public ActionResult<List<ToDoList>> Get()
        {
            return _toDoListService.Get();
        }

        [HttpGet("{id}")]
        public ToDoList Get(string id)
        {
            return _toDoListService.Get(id);
        }

        [HttpGet("ByUserId/{id}")]
        public ActionResult<List<ToDoList>> GetByUserId(string id)
        {
            return _toDoListService.GetByUserId(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ToDoList toDoList)
        {
            _toDoListService.Create(toDoList);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] ToDoList toDoList)
        {
            _toDoListService.Update(id, toDoList);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _toDoListService.Remove(id);
            return Ok();
        }
    }
}
