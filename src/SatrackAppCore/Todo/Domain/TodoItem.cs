using System;

namespace SatrackAppCore.Todo.Domain;

public class TodoItem
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public Guid UserId { get; set; }
    public string Category { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAtDate { get; set; }
    public DateTime DueDate { get; set; }
}