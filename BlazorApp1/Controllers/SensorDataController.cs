using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BlazorApp1.Controllers
{
    // SensorDataController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class SensorDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly NavbarService _vs;


        public SensorDataController(ApplicationDbContext context, NavbarService vs)
        {
            Console.WriteLine("SensorDataController Constructs a context here. It should utilize a service, not a direct context like now.");

            _context = context;
            _vs = vs;
        }


        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm] IFormFile file)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            Console.WriteLine("Inside SensorDataController Upload method here. It should utilize a service, not a direct context like now.");
            _vs.ToggleNavbar();
            return Ok(new { Message = "File uploaded successfully!" });
        }

        [HttpPost]
        public async Task<IActionResult> PostSensorData([FromForm] IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                var receivedData = Encoding.UTF8.GetString(memoryStream.ToArray());

                // Process and save the received data to the database
                _context.Add(new YourSensorDataModel { SensorData = receivedData });
                await _context.SaveChangesAsync();
                Console.WriteLine("PostSensorData method here. It should utilize a service, not a direct context like now.");

                return Ok(new { Message = "Data received and saved successfully!" });
            }
        }

        //var sensorDataModel = new YourSensorDataModel { SensorData = sensorData }; 
        // Create a new instance of the data model with the received sensor data

        //_context.SensorData.Add(sensorDataModel); // Add the new sensor data to the DbSet in the database context
        // await _context.SaveChangesAsync(); // Save changes to the database asynchronously

        // Optional: Add a console log to indicate that the sensor data has been received and saved
        // Console.WriteLine($"Sensor data received and saved: {sensorData}");

        //return Ok(); // Returns an HTTP 200 OK status to indicate success

    }

}

