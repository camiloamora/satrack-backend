using SatrackAppCore.Todo.Infrastructure.Persistence;

namespace SatrackApp.Apps.Backend.Setting
{
    public class MongoDbSettings : IMongoDatabaseSettings
    {
        public string DatabaseConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}