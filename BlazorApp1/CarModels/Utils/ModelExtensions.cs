using System;
using System.Text.Json;

namespace BlazorApp1.CarModels.Utils
{
    public interface ILoggable
    {
        // You can leave this empty if you don't need to enforce any members
    }

    public static class ModelExtensions
    {
        public static void LogModelState(this ILoggable model)
        {
            var serializedModel = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine($"Model state: {serializedModel}");
        }
    }

    public class SomeLoggableClass : ILoggable
    {
        // Your implementation here
    }
}
