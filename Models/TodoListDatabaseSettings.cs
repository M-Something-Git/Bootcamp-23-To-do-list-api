namespace Bootcamp_23_todo_list_api.Models
{
    public class TodoListDatabaseSettings : ITodoListDatabaseSettings
    {
        public string TodoListCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
