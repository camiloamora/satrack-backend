using Microsoft.AspNetCore.Mvc;
using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Infrastructure.Dto;
using SatrackAppCore.Todo.Application.Update;
using System.Threading.Tasks;

namespace SatrackApp.Apps.Backend.Controllers.Todo;

[ApiController]
[Route("v1/todos")]
public class TodoPatchController : Controller
{
    private readonly ITodoRepository _todoRepository;

    public TodoPatchController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult> Index([FromRoute] Guid id)
    {
        var updateTodo = new TodoUpdate(_todoRepository);
        var result = await updateTodo.Update(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(new { Id = result });
    }

}