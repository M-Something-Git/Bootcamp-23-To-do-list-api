using Bootcamp_23_todo_list_api.Models;
using MongoDB.Driver;
namespace Bootcamp_23_todo_list_api.Services
{
    public class ToDoListService : IToDoListService
    {
        private readonly IMongoCollection<ToDoList> _todolist;

        public ToDoListService(ITodoListDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
          _todolist = database.GetCollection<ToDoList>(settings.TodoListCollectionName);
        }
        public ToDoList Create(ToDoList toDoList)
        {
            _todolist.InsertOne(toDoList);
           return toDoList;
        }

        public List<ToDoList> Get()
        {
           return _todolist.Find(toDoList => true).ToList();
        }

        public ToDoList Get(string id)
        {
            return _todolist.Find(toDoList => toDoList.Id == id).FirstOrDefault();
        }

        public List<ToDoList> GetByUserId(string byUserId)
        {
            return _todolist.Find(toDoList => toDoList.UserId == byUserId).ToList();
        }

        public void Remove(string id)
        {
           _todolist.DeleteOne(toDoList => toDoList.Id == id);
        }

        public void Update(string id, ToDoList toDoListIn)
        {
            _todolist.ReplaceOne(toDoList => toDoList.Id == id, toDoListIn);
        }
    }
}
