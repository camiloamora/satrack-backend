using System.Collections.Generic;
using System;

namespace SatrackAppCore.Todo.Infrastructure.Dto;

public class TodoReadDtos
{
    public readonly IEnumerable<TodoReadDto> Todos;

    public TodoReadDtos(IEnumerable<TodoReadDto> todos)
    {
        Todos = todos;
    }
}