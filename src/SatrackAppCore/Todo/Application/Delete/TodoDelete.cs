using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Infrastructure.Dto;
using System.Threading.Tasks;
using System;

namespace SatrackAppCore.Todo.Application.Delete;

public class TodoDelete
{
    private readonly ITodoRepository _repository;
    public TodoDelete(ITodoRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _repository.DeleteById(id);
        return id;
    }
}