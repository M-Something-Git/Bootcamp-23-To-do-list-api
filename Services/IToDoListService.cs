using Bootcamp_23_todo_list_api.Models;

namespace Bootcamp_23_todo_list_api.Services
{
    public interface IToDoListService
    {
        List<ToDoList> Get();
        ToDoList Get(string id);
        List<ToDoList> GetByUserId(string byUserId);
        ToDoList Create(ToDoList toDoList);
        void Update(string id, ToDoList toDoListIn);
        void Remove(string id);

    }
}
