using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bootcamp_23_todo_list_api.library.Models;
using Bootcamp_23_todo_list_api.library.Services;

namespace Bootcamp_23_todo_list_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListService _toDoListService;
        public ToDoListsController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoList>>> GetToDoLists()
        {
            return await _toDoListService.GetAllItemsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoList>> GetToDoList(int id)
        {
            return await _toDoListService.GetItemByIdAsync(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDoList(int id, ToDoList toDoList)
        {
            await _toDoListService.UpdateItemAsync(id, toDoList);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostToDoList(ToDoList toDoList)
        {
            await _toDoListService.AddItemAsync(toDoList);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            await _toDoListService.DeleteItemAsync(id);
            return NoContent();
        }
    }
}
