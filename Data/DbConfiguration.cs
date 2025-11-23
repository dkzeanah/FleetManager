using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public static class DbConfiguration
{
    public static void AddGuildDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var provider = configuration.GetValue<string>("DatabaseProvider") ?? "Sqlite";

        services.AddDbContext<GuildDbContext>(options =>
        {
            if (provider.Equals("PostgreSQL", StringComparison.OrdinalIgnoreCase))
            {
                var connectionString = configuration.GetConnectionString("GuildDbPostgres")
                    ?? throw new InvalidOperationException("Connection string 'GuildDbPostgres' not found.");
                options.UseNpgsql(connectionString);
                Console.WriteLine("GuildDbContext using PostgreSQL");
            }
            else
            {
                var connectionString = configuration.GetConnectionString("GuildDbSqlite")
                    ?? throw new InvalidOperationException("Connection string 'GuildDbSqlite' not found.");
                options.UseSqlite(connectionString);
                Console.WriteLine("GuildDbContext using SQLite");
            }

            options.EnableSensitiveDataLogging();
            options.EnableDetailedErrors();
        });
    }
}
