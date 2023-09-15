namespace SatrackAppCore.Todo.Infrastructure.Persistence;
public interface IMongoDatabaseSettings
{
    string CollectionName { get; set; }
    string DatabaseConnectionString { get; set; }
    string DatabaseName { get; set; }
}