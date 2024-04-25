using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace BlazorApp1.CarModels
{
    public class DynamicEntity : IMaintainable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        public void AddProperty(string key, object value)
        {
            Console.WriteLine($"Adding property to DynamicEntity: Key={key}, Value={value}");
            _properties[key] = value;
        }

        public void UpdateProperty(string key, object value)
        {
            Console.WriteLine($"Updating property in DynamicEntity: Key={key}, Value={value}");

            if (_properties.ContainsKey(key))
            {
                _properties[key] = value;
            }
            else
            {
                throw new KeyNotFoundException($"Property {key} not found.");
            }
        }

        public object GetProperty(string key)
        {
            Console.WriteLine($"Getting property from DynamicEntity: Key={key}");

            if (_properties.TryGetValue(key, out var value))
            {
                return value;
            }

            throw new KeyNotFoundException($"Property {key} not found.");
        }

        public bool RemoveProperty(string key)
        {
            Console.WriteLine($"Removing property from DynamicEntity: Key={key}");

            return _properties.Remove(key);
        }
        public string GetPropertiesAsJson()
        {
            return JsonSerializer.Serialize(_properties);
        }
    }

}
