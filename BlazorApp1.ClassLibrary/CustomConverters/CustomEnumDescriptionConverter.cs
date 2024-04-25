using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorApp1.ClassLibrary.CustomConverters
{
    public class CustomEnumDescriptionConverter<T> : JsonConverter<T> where T : Enum
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptions = (DescriptionAttribute)fieldInfo
                .GetCustomAttribute(typeof(DescriptionAttribute), false);
            writer.WriteStringValue(descriptions?.Description);
        }
    }
}
