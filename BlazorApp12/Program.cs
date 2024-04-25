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


namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


/*            
*/
    
            // Add services to the container.
            builder.Services.AddLogging(builder => builder.AddConsole());

                //add database connection strings 
            var carsConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            var CarsSQLiteConnectionString = builder.Configuration.GetConnectionString("SQLiteConnection") 
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            var CalendarConnectionString = builder.Configuration.GetConnectionString("SQLite2Connection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddSingleton(new JsonSerializerOptions
            {
                WriteIndented = true, // Pretty-print the JSON
                                      // Other options as needed...
            });

            #region =====[ DB registration ]========================================home
            //SQLite DB
            builder.Services.AddDbContext<ApplicationSQLiteDbContext>(options =>
                options.UseSqlite(CarsSQLiteConnectionString)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());
            Console.WriteLine("SQLite registered.");

            //SQL Server DB
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(carsConnectionString));
            Console.WriteLine("SQL registered.");
            // builder.Services.AddDbContext<CalendarDbContext>(options =>
            //    options.UseInMemoryDatabase("CalendarDb").EnableSensitiveDataLogging(true));
            #endregion

            //SQLite registered repositories/services (Dummy db)
            builder.Services.AddScoped<IBlankRepository, BlankRepository>();
            builder.Services.AddScoped<IBlankService, BlankService>();
            builder.Services.AddScoped<IExcelDataRecordRepository, ExcelDataRecordRepository>();
            builder.Services.AddScoped<IExcelDataRecordService, ExcelDataRecordService>();
            


           

            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            //builder.Services.AddScoped<IOrderOperations, SQLiteOrderOperations>();

            //SQL Identity Managers etc
            builder.Services.AddScoped<UserManager<ApplicationUser>>();
            builder.Services.AddScoped<AuthenticationStateProvider,RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>>();
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Identity
            builder.Services
                .AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // HavIt<------ ADD THIS LINE
            builder.Services.AddHxServices();

            //Transient - New instance every time
            //scoped - Same instance within the scope of a client request


            // Non-dependancy (dep-free) ((hopefully))
            builder.Services.AddScoped<IEventTypeRepository, EventTypeRepository>();
            builder.Services.AddScoped<IEventTypeService, EventTypeService>();

            builder.Services.AddScoped<IStatusRepository, StatusRepository>();
            builder.Services.AddScoped<IStatusService, StatusService>();
            
            builder.Services.AddScoped<IRoleEventMappingRepository, RoleEventMappingRepository>();
            builder.Services.AddScoped<IRoleEventMappingService, RoleEventMappingService>();

            // Register Users-Core
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();

            // Register Cars-Core
            builder.Services.AddScoped<ICarRepository, CarRepository>();
            builder.Services.AddScoped<ICarService, CarService>(); //Contains Car & CarStaticDetail & DTO

           // builder.Services.AddTransient<ICar2Repository, Car2Repository>();
            //builder.Services.AddTransient<ICar2Service, Car2Service>(); //Contains Car & CarStaticDetail & DTO

            //builder.Services.AddTransient<ICarStaticDetailRepository, CarStaticDetailRepository>(); //single service //utilises DTO
           // builder.Services.AddTransient<ICarStaticDetailService, CarStaticDetailService>();

            //Register Car-Related's
            //builder.Services.AddTransient<IIssueRepository, IssueRepository>();
            //builder.Services.AddTransient<IIssueService, IssueService>();

            builder.Services.AddTransient<ILoggerRepository, LoggerRepository>();
            builder.Services.AddTransient<ILoggerService, LoggerService>();

            //builder.Services.AddTransient<ISoftwareRepository, SoftwareRepository>();
            //builder.Services.AddTransient<ISoftwareService, SoftwareService>();

            //Register Car-User Related
            builder.Services.AddTransient<IUserCarEventRepository, UserCarEventRepository>();
            builder.Services.AddTransient<IUserCarEventService, UserCarEventService>();
           // builder.Services.AddTransient<IUserEventDetailRepository, UserEventDetailRepository>();
           // builder.Services.AddTransient<IUserEventDetailService, UserEventDetailService>();

            builder.Services.AddTransient<ICarEventDetailRepository, CarEventDetailRepository>();
            builder.Services.AddTransient<ICarEventDetailService, CarEventDetailService>();

           




            Console.WriteLine("Service: search service [x]");



            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();


            





            //builder.Services.AddScoped<IssueService>();
            //builder.Services.AddSingleton<WeatherForecastService>();

            var app = builder.Build();


            /*
/*
            try
            {
                using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope()) //ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    context.Database.OpenConnection();
                    context.Database.CloseConnection();
                }
                Console.WriteLine("Connected to the database successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while connecting to the database: {ex.Message} \n - Previously, Not adding a space at 'userid=' in the connection string was the source of error");
            }
            */
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                try
                {
                    using var scope = app.Services.CreateScope();
                    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

                    string[] roleNames = { "Admin", "Organizer", "Driver", "Technician", "Contact" };

                    foreach (var roleName in roleNames)
                    {
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
            // Ensure roles are created
            /*using (var scope = app.Services.CreateScope())
            {
                await EnsureRolesCreated(scope.ServiceProvider);
            }*/
            /*using (var scope = app.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

                string[] roleNames = { "Admin", "Organizer", "Driver", "Technician", "Contact" };

                foreach (var roleName in roleNames)
                {
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
            }*/

            //app.UseHsts();
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();

        }
        
    }
}