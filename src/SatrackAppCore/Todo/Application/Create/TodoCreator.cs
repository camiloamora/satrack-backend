using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Infrastructure.Dto;
using System.Threading.Tasks;
using System;

namespace SatrackAppCore.Todo.Application.Create
{
    public class TodoCreator
    {
        private readonly ITodoRepository _repository;
        public TodoCreator(ITodoRepository repository)
        {
            _repository = repository;
        }
        public async Task Create(TodoCreateDto todo)
        {
            var newTodo = new TodoItem
            {
                Id = Guid.NewGuid(),
                Description = todo.Descripcion,
                UserId = Guid.NewGuid(),
                Category = todo.Categoria,
                Status = todo.Estado,
                CreatedAtDate = DateTime.Now,
                DueDate = todo.FechaFinalizacion
            };
            await _repository.Save(newTodo);
        }
    }
}
