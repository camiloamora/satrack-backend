using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SatrackAppCore.Todo.Domain;

public interface ITodoRepository
{
    Task Save(TodoItem todo);
    Task<ICollection<TodoItem>> SearchAll();
    Task UpdateById(Guid Id);
    Task DeleteById(Guid Id);
}