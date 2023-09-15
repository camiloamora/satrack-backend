using Microsoft.AspNetCore.Mvc;
using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Application.Delete;
using System.Threading.Tasks;

namespace SatrackApp.Apps.Backend.Controllers.Todo;

[ApiController]
[Route("v1/todos")]
public class TodoDeleteController : Controller
{
    private readonly ITodoRepository _todoRepository;

    public TodoDeleteController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Index([FromRoute] Guid id)
    {
        var deleteTodo = new TodoDelete(_todoRepository);
        var result = await deleteTodo.Delete(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(new { Id = result });
    }
}