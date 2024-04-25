using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace BlazorApp1.CarModels
{
    public class Dynamo : IVirtual
    {
        [Key]
        public int Id { get; set; } // Primary Key for EF Core
        public string Configuration { get; set; }

        public void AddOrUpdateProperty(string key, object value)
        {
            Console.WriteLine($"Adding/Updating property in Dynamo: Key={key}, Value={value}");

            var config = string.IsNullOrEmpty(Configuration) ? new Dictionary<string, object>() : JsonSerializer.Deserialize<Dictionary<string, object>>(Configuration);
            config[key] = value;
            Configuration = JsonSerializer.Serialize(config);
        }

        public T GetProperty<T>(string key)
        {
            Console.WriteLine($"Getting property from Dynamo: Key={key}");

            var config = JsonSerializer.Deserialize<Dictionary<string, object>>(Configuration);
            if (config != null && config.TryGetValue(key, out var value))
            {
                return JsonSerializer.Deserialize<T>(value.ToString());
            }

            throw new KeyNotFoundException($"Property {key} not found.");
        }
    }
}
