namespace BlazorApp1.CarModels.Utils
{
    public class DatabaseSchema
    {
        public List<EntitySchema> Schema { get; set; }
        public Dictionary<string, List<Dictionary<string, object>>> Data { get; set; }
    }

    public class EntitySchema
    {
        public string Name { get; set; }
        public List<PropertySchema> Properties { get; set; }
        public List<KeySchema> Keys { get; set; }
        public List<IndexSchema> Indexes { get; set; }
    }

    public class PropertySchema
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class KeySchema
    {
        public List<string> Properties { get; set; }
    }

    public class IndexSchema
    {
        public List<string> Properties { get; set; }
        public bool IsUnique { get; set; }
    }

}
