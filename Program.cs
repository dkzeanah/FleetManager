using BlazorApp1.Areas.Identity;
using BlazorApp1.CarModels;
using BlazorApp1.Areas.Identity;
using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services;
using BlazorApp1.Services.Interfaces;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Havit.Blazor.Components.Web;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System.Text.Json;
using BlazorApp1.Grid;
using BlazorServerEFCoreSample.Data;

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
            // Use real data:
            //services.AddScoped<IDbContext, ApplicationDbContext>();

            // Use mock data:
            // services.AddScoped<IDbContext, MockDbContext>();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(carsConnectionString));
            Console.WriteLine("ApplicationDbContext registered.");

            builder.Services.AddSingleton(new JsonSerializerOptions
            {
                WriteIndented = true, // Pretty-print the JSON
                                      // Other options as needed...
            });

            builder.Services.AddScoped<IBlankRepository, BlankRepository>();
            builder.Services.AddScoped<IBlankService, BlankService>();
            builder.Services.AddScoped<IExcelDataRecordRepository, ExcelDataRecordRepository>();
            builder.Services.AddScoped<IExcelDataRecordService, ExcelDataRecordService>();
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

  
            Console.WriteLine("! \n\n\n End Services \n\n\n !");





            //builder.Services.AddScoped<IssueService>();
            //builder.Services.AddSingleton<WeatherForecastService>();

             var app = builder.Build();


            await using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateAsyncScope();
            var options = scope.ServiceProvider.GetRequiredService<DbContextOptions<ContactContext>>();
            await DatabaseUtility.EnsureDbCreatedAndSeedWithCountOfAsync(options, 500);



            /*using (var scope = app.Services.CreateScope())
            {
                await EnsureRolesCreated(scope.ServiceProvider);
            }*/

            /*                    try
                                {
                                    using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope()) //ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                                    {
                                        var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                            await EnsureRolesCreated((IServiceProvider)context);

                            *//* context.Database.OpenConnection();
                                        context.Database.CloseConnection();*//*
                        }
                        Console.WriteLine("Connected to the database successfully.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"An error occurred while connecting to the database: {ex.Message} \n - Previously, Not adding a space at 'userid=' in the connection string was the source of error");
                                }*/

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

           // app.MapControllers();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();

        }
        public static async Task EnsureRolesCreated(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Organizer","Driver", "Contact","Technician", "Visitor" };

            foreach (var roleName in roleNames)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
        /*public static class RoleInitializer
        {
            public static async Task InitializeAsync(RoleManager<IdentityRole> roleManager)
            {
                foreach (var role in new[] { Roles.Admin, Roles.Technician *//*, other roles *//* })
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                    }
                }
            }
        }*/

    }
}