using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SatrackAppCore.Todo.Infrastructure.Dto;

public class TodoCreateDto
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid UserId { get; set; }
    public string Descripcion { get; set; }
    public string Categoria { get; set; }
    public string Estado { get; set; }
    public DateTime FechaFinalizacion { get; set; }
}