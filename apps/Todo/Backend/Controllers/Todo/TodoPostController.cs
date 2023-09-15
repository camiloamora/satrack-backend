using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SatrackAppCore.Todo.Application.Create;
using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Infrastructure.Dto;
using System.Threading.Tasks;

namespace SatrackApp.Apps.Backend.Controllers.Todo;

[ApiController]
[Route("v1/todos")]
public class TodoPostController : Controller
{
    //private readonly TodoCreator _todoCreator;
    private readonly ITodoRepository _todoRepository;

    public TodoPostController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromBody] TodoCreateDto todo)
    {
        var _todoCreator = new TodoCreator(_todoRepository);
        await _todoCreator.Create(todo);
        return Ok(new { message = "OK" });
    }
}
