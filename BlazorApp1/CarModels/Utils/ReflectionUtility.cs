using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.CarModels.Utils
{

        public static class DbContextExtensions
        {
            public static IEnumerable<Type> GetDbSetTypes(this DbContext context)
            {
                return context.GetType().GetProperties()
                    .Where(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                    .Select(p => p.PropertyType.GetGenericArguments().First());
            }
        }

    }

