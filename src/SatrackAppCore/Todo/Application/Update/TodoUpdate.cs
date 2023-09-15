using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Infrastructure.Dto;
using System.Threading.Tasks;
using System;

namespace SatrackAppCore.Todo.Application.Update;

public class TodoUpdate
{
    private readonly ITodoRepository _repository;
    public TodoUpdate(ITodoRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Update(Guid id)
    {
        await _repository.UpdateById(id);
        return id;
    }
}