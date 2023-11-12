namespace Bootcamp_23_todo_list_api.Models
{
    public interface ITodoListDatabaseSettings
    {
        public string TodoListCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
