using System;
using System.Collections.Generic;

namespace Bootcamp_23_todo_list_api.Models;

public partial class ToDoList
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Task { get; set; } = null!;

    public string Status { get; set; } = null!;
}
