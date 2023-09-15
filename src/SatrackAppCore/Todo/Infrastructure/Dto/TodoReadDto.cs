using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using SatrackAppCore.Todo.Domain;

namespace SatrackAppCore.Todo.Infrastructure.Dto;

public class TodoReadDto
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; }
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid UserId { get; }
    public string Descripcion { get; }
    public string Categoria { get; }
    public string Estado { get; }
    public DateTime FechaFinalizacion { get; }

    public DateTime CreatedAtDate { get; }

    public TodoReadDto(Guid id, string descripcion, Guid userId, string categoria, string estado, DateTime createdAtDate, DateTime fechaFinalizacion)
    {
        Id = id;
        UserId = userId;
        Descripcion = descripcion;
        Categoria = categoria;
        Estado = estado;
        FechaFinalizacion = fechaFinalizacion;
        CreatedAtDate = createdAtDate;
    }

    public static TodoReadDto TransformTodoRead(TodoItem todo)
    {
        return new TodoReadDto(
            todo.Id,
            todo.Description,
            todo.UserId,
            todo.Category,
            todo.Status,
            todo.CreatedAtDate,
            todo.DueDate
            );
    }
}