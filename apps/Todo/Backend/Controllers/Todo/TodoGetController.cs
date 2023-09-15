using Microsoft.AspNetCore.Mvc;
using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Application;
using SatrackAppCore.Todo.Infrastructure.Dto;
using System;

namespace SatrackApp.Apps.Backend.Controllers.Todo;

[ApiController]
[Route("v1/todos")]
public class GetTodoController : Controller
{
    private readonly ITodoRepository _todoRepository;

    public GetTodoController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoReadDto>>> Index()
    {
        var todo = (await _todoRepository.SearchAll()).Select(TodoReadDto.TransformTodoRead);
        return Ok(todo);
    }
}