using BlazorApp1.Areas.Identity;
using BlazorApp1.CarModels;
using BlazorApp1.Areas.Identity;
using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories;
using BlazorApp1.Services;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Havit.Blazor.Components.Web;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System.Text.Json;
using BlazorApp1.Grid;
using BlazorApp1.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using BlazorApp1.ClassLibrary.Services;
using BlazorApp1.CarModels.Utils;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.Internal;

namespace BlazorApp1
{
  public class Program
  {
    public static async System.Threading.Tasks.Task Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.
      builder.Services.AddLogging(builder => builder.AddConsole());

      var carsConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
      //var carsConnectionString = builder.Configuration.GetConnectionString("CarsConnection") ?? throw new InvalidOperationException($"Connection string 'CarsConnection' not found.");
      //var ConsolidatedConnectionString = builder.Configuration.GetConnectionString("ConsolidatedConnection") ?? throw new InvalidOperationException($"Connection string 'CarsConnection' not found.");
      var CarsSQLiteConnectionString = builder.Configuration.GetConnectionString("SqliteConnection")
          ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

      //SQLite DB
      /* builder.Services.AddDbContext<ContactContext>(options =>
           options.

           UseSqlite(CarsSQLiteConnectionString)
           .EnableSensitiveDataLogging()
           .EnableDetailedErrors());*/

      Console.WriteLine("SQLite registered.");



      builder.Services.AddDbContextFactory<ContactContext>(options =>
      options.UseSqlite($"Data Source={nameof(ContactContext.ContactsDb)}.db"));

      builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
          options.UseSqlServer(carsConnectionString));
      builder.Services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(carsConnectionString));

      //builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
      //    options.UseSqlServer(carsConnectionString));
      Console.WriteLine("ApplicationDbContextFactory registered.");

      builder.Services.AddSingleton(new JsonSerializerOptions
      {
        WriteIndented = true, // Pretty-print the JSON
                              // Other options as needed...
      });

      builder.Services.AddScoped<IBlankRepository, BlankRepository>();
      builder.Services.AddScoped<IBlankService, BlankService>();
      builder.Services.AddScoped<ITaskModelRepository, TaskModelRepository>();
      builder.Services.AddScoped<ITaskModelService, TaskModelService>();
      builder.Services.AddScoped<IExcelDataRecordRepository, ExcelDataRecordRepository>();
      builder.Services.AddScoped<IExcelDataRecordService, ExcelDataRecordService>();

      builder.Services.AddScoped<PaymentRepository>();
      builder.Services.AddScoped<PaymentService>();
      /*
                  builder.Services.AddScoped<UserManager<ApplicationUser>>();
                  builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>>();
                  builder.Services.AddDatabaseDeveloperPageExceptionFilter();*/


      builder.Services.AddDefaultIdentity<ApplicationUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
      ;

      builder.Services.AddScoped<UserManager<ApplicationUser>>();

      builder.Services
          .AddScoped<AuthenticationStateProvider,
              RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>>();
      builder.Services.AddDatabaseDeveloperPageExceptionFilter();



      builder.Services.AddHxServices();        // <------ ADD THIS LINE
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();

      // pager
      builder.Services.AddScoped<IPageHelper, PageHelper>();
      // filters
      builder.Services.AddScoped<IContactFilters, GridControls>();
      // query adapter (applies filter to contact request).
      builder.Services.AddScoped<GridQueryAdapter>();
      // service to communicate success on edit between pages
      builder.Services.AddScoped<EditSuccess>();


      builder.Services.AddScoped<ISourceRepository, SourceRepository>();


      builder.Services.AddScoped<IBlankRepository, BlankRepository>();
      builder.Services.AddScoped<IBlankService, BlankService>();

      builder.Services.AddScoped<IOrderRepository, OrderRepository>();
      builder.Services.AddScoped<IOrderService, OrderService>();


      builder.Services.AddScoped<ITaskModelRepository, TaskModelRepository>();

      builder.Services.AddScoped<IEventTypeRepository, EventTypeRepository>();
      builder.Services.AddScoped<IEventTypeService, EventTypeService>();
      builder.Services.AddScoped<ISimpleEventTypeRepository, SimpleEventTypeRepository>();
      builder.Services.AddScoped<ISimpleEventTypeService, SimpleEventTypeService>();

      builder.Services.AddScoped<IStatusRepository, StatusRepository>();
      builder.Services.AddScoped<IStatusService, StatusService>();

      // Register Users-Core
      builder.Services.AddScoped<IUserRepository, UserRepository>();
      builder.Services.AddScoped<IUserService, UserService>();

      // Register Cars-Core
      builder.Services.AddScoped<ICarRepository, CarRepository>();
      builder.Services.AddScoped<ICarDetailRepository, CarDetailRepository>(); //single service //utilises DTO
      builder.Services.AddScoped<ICarService, CarService>(); //Contains Car & CarStaticDetail & DTO


      //Register Car-Related's
      builder.Services.AddScoped<IIssueRepository, IssueRepository>();
      builder.Services.AddScoped<IIssueService, IssueService>();

      builder.Services.AddScoped<ILoggerRepository, LoggerRepository>();
      builder.Services.AddScoped<ILoggerService, LoggerService>();

      builder.Services.AddScoped<IModuleRepository, ModuleRepository>();
      builder.Services.AddScoped<IModuleService, ModuleService>();

      builder.Services.AddScoped<ISoftwareRepository, SoftwareRepository>();
      builder.Services.AddScoped<ISoftwareService, SoftwareService>();

      //Register Car-User Related
      builder.Services.AddScoped<IEventRepository, EventRepository>();
      builder.Services.AddScoped<IEventService, EventService>();

      builder.Services.AddScoped<IUserEventDetailRepository, UserEventDetailRepository>();
      builder.Services.AddScoped<IUserEventDetailService, UserEventDetailService>();


      builder.Services.AddScoped<ICarEventDetailRepository, CarEventDetailRepository>();
      builder.Services.AddScoped<ICarEventDetailService, CarEventDetailService>();

      builder.Services.AddScoped<IRoleEventMappingRepository, RoleEventMappingRepository>();
      builder.Services.AddScoped<IRoleEventMappingService, RoleEventMappingService>();

      // builder.Services.AddScoped<ICalendarRepository, CalendarRepository>();


      builder.Services.AddSingleton<NavbarService>();
      builder.Services.AddSingleton<ExchangeService>();


      builder.Services.AddScoped<IImageToAsciiConverter, ImageToAsciiConverter>();
      builder.Services.AddSingleton<HttpClient>();



      builder.WebHost.UseStaticWebAssets();

      builder.Services.AddBlazorToastr();


      Console.WriteLine("! \n\n\n End Services \n\n\n !");





      //builder.Services.AddScoped<IssueService>();
      //builder.Services.AddSingleton<WeatherForecastService>();

      var app = builder.Build();

      await ExportDatabaseSchema(app.Services);


      await using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateAsyncScope();
      var options = scope.ServiceProvider.GetRequiredService<DbContextOptions<ContactContext>>();
      await DatabaseUtility.EnsureDbCreatedAndSeedWithCountOfAsync(options, 500);



      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        try
        {
          // using var scope = app.Services.CreateScope();
          var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
          var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

          string[] roleNames = { "Admin", "Organizer", "Driver", "Technician", "Contact" };

          foreach (var roleName in roleNames)
          {
            //var roleExists = await roleManager.Roles.AnyAsync(r => r.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase));

            var roleExists = await roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
              var roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
              if (roleResult.Succeeded)
              {
                logger.LogInformation($"Role {roleName} successfully created.");
              }
              else
              {
                // Handle errors
                logger.LogError($"Error creating role {roleName}.");
              }
            }
            else
            {
              logger.LogInformation($"Role {roleName} already exists.");
            }
          }
        }
        catch (Exception ex)
        {
          // Handle errors // Log the exception and rethrow
          var logger = app.Services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred while setting up roles.");
          throw;
        }
        app.UseMigrationsEndPoint();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

     
        


          app.UseHttpsRedirection();

          app.UseStaticFiles();

          app.UseRouting();

          app.UseAuthentication();
          app.UseAuthorization();


          app.Map("/api/qapi", appBuilder => appBuilder.Run(async context =>
          {
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync("{\"Message\":\"Hello from the API\"}");
          }));

          // app.MapControllers();
          app.MapBlazorHub();
          app.MapHub<UpdateHub>("/updateHub");
          app.MapControllers();
          app.MapFallbackToPage("/_Host");

          app.Run();

        }
        public static async Task EnsureRolesCreated(IServiceProvider serviceProvider)
        {
          var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
          string[] roleNames = { "Admin", "Organizer", "Driver", "Contact", "Technician", "Visitor" };

          foreach (var roleName in roleNames)
          {
            var roleExists = await roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
              await roleManager.CreateAsync(new IdentityRole(roleName));
            }
          }
        }





    private static async Task ExportDatabaseSchema(IServiceProvider serviceProvider)
    {
      using var scope = serviceProvider.CreateScope();
      var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

      var model = dbContext.Model;
      var schemaInfo = new List<object>();

      foreach (var entityType in model.GetEntityTypes())
      {
        var entityInfo = new
        {
          Name = entityType.Name,
          Properties = entityType.GetProperties().Select(p => new { p.Name, Type = p.ClrType.Name }).ToList(),
          Keys = entityType.GetKeys().Select(k => new
          {
            Properties = k.Properties.Select(p => p.Name).ToList()
          }).ToList(),
          Indexes = entityType.GetIndexes().Select(i => new
          {
            //Name = i.GetName(),
            Properties = i.Properties.Select(p => p.Name).ToList(),
            i.IsUnique
          }).ToList()
        };
        schemaInfo.Add(entityInfo);
      }

      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      var json = JsonSerializer.Serialize(schemaInfo, jsonOptions);

      await File.WriteAllTextAsync("EF_Schema.json", json);
    }
    /*private static async Task ExportDatabaseAndData(IServiceProvider serviceProvider)
    {
      using var scope = serviceProvider.CreateScope();
      var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

      var model = dbContext.Model;
      var schemaInfo = new List<object>();
      var tableData = new Dictionary<string, List<object>>();

      foreach (var entityType in model.GetEntityTypes())
      {
        // Skip owned entity types
        if (entityType.IsOwned())
        {
          continue;
        }

        // Extract schema information
        var entityInfo = new
        {
          Name = entityType.Name,
          Properties = entityType.GetProperties().Select(p => new { p.Name, Type = p.ClrType.Name }).ToList(),
          Keys = entityType.GetKeys().Select(k => new
          {
            Properties = k.Properties.Select(p => p.Name).ToList()
          }).ToList(),
          Indexes = entityType.GetIndexes().Select(i => new
          {
            Properties = i.Properties.Select(p => p.Name).ToList(),
            i.IsUnique
          }).ToList()
        };
        schemaInfo.Add(entityInfo);

        // Extract table data using reflection
        var method = typeof(DbContext).GetMethod(nameof(DbContext.Set), Type.EmptyTypes)?.MakeGenericMethod(entityType.ClrType);
        if (method != null)
        {
          var queryable = (IQueryable)method.Invoke(dbContext, null);
          var dataList = await queryable.Cast<object>().ToListAsync();
          tableData.Add(entityType.Name, dataList);
        }
      }

      var combinedData = new
      {
        Schema = schemaInfo,
        Data = tableData
      };

      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      var json = JsonSerializer.Serialize(combinedData, jsonOptions);

      await File.WriteAllTextAsync("EF_SchemaAndData.json", json);
    }
*/
    private static async Task ExportDatabaseAndData(IServiceProvider serviceProvider)
    {
      using var scope = serviceProvider.CreateScope();
      var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

      var model = dbContext.Model;
      var schemaInfo = new List<object>();
      var tableData = new Dictionary<string, List<object>>();

      foreach (var entityType in model.GetEntityTypes())
      {
        // Skip owned entity types
        if (entityType.IsOwned())
        {
          continue;
        }

        // Extract schema information
        var entityInfo = new
        {
          Name = entityType.Name,
          Properties = entityType.GetProperties().Select(p => new { p.Name, Type = p.ClrType.Name }).ToList(),
          Keys = entityType.GetKeys().Select(k => new
          {
            Properties = k.Properties.Select(p => p.Name).ToList()
          }).ToList(),
          Indexes = entityType.GetIndexes().Select(i => new
          {
            Properties = i.Properties.Select(p => p.Name).ToList(),
            i.IsUnique
          }).ToList()
        };
        schemaInfo.Add(entityInfo);

        try
        {
          // Try to extract table data
          var method = typeof(DbContext).GetMethod(nameof(DbContext.Set), Type.EmptyTypes)?.MakeGenericMethod(entityType.ClrType);
          if (method == null) continue;

          var queryable = (IQueryable)method.Invoke(dbContext, null);
          var dataList = await queryable.Cast<object>().ToListAsync();
          tableData.Add(entityType.Name, dataList);
        }
        catch (InvalidOperationException)
        {
          // Handle cases where the entity type is shared-type or otherwise not directly accessible
          // You can log this exception or handle it as needed
        }
      }

      var combinedData = new
      {
        Schema = schemaInfo,
        Data = tableData
      };

      var jsonOptions = new JsonSerializerOptions
      {
        WriteIndented = true,
        ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
      };

      var json = JsonSerializer.Serialize(combinedData, jsonOptions);

      await File.WriteAllTextAsync("EF_SchemaAndData.json", json);
      //var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      //var json = JsonSerializer.Serialize(combinedData, jsonOptions);

      //await File.WriteAllTextAsync("EF_SchemaAndData.json", json);
    }




  }
}

    
  