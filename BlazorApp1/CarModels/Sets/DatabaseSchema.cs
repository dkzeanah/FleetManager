using System.Text.Json.Serialization;

namespace BlazorApp1.CarModels.Sets
{
  public class DatabaseSchema2
  {
    public List<EntitySchema> Schema { get; set; }
    public Dictionary<string, List<Dictionary<string, object>>> Data { get; set; }
  }

  public class EntitySchema2
  {
    public string Name { get; set; }
    public List<PropertySchema> Properties { get; set; }
    public List<KeySchema2> Keys { get; set; }
    public List<IndexSchema2> Indexes { get; set; }
  }


  public class PropertySchema2
  {
    public string Name { get; set; }
    public string Type { get; set; }
  }

  public class KeySchema2
  {
    public List<string> Properties { get; set; }
  }

  public class IndexSchema2
  {
    public List<string> Properties { get; set; }
    public bool IsUnique { get; set; }
  }
  public class DatabaseSchema
  {
    public ValueList<EntitySchema> Schema { get; set; }
    public Dictionary<string, List<Dictionary<string, object>>> Data { get; set; }
  }

  public class EntitySchema
  {
    public string Name { get; set; }
    public ValueList<PropertySchema> Properties { get; set; }
  }

  public class PropertySchema
  {
    public string Name { get; set; }
    public string Type { get; set; }
  }

  public class ValueList<T>
  {
    [JsonPropertyName("$values")]
    public List<T> Values { get; set; }
  }



}
