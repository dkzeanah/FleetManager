using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;
using BlazorApp1.Repositories.Interfaces;

public class MockCarRepository : ICarRepository
{
    private List<Car> _cars;
    private List<CarEvent> _carEvents;
    private List<Event> _events;

    public MockCarRepository()
    {
        /*_events = new List<Event>()
        {
            new Event { Id = 1, Type = "Racing" },
            new Event { Id = 2, Type = "Show" },
        };

        _cars = new List<Car>()
        {
            new Car { CarId = 1, Make = "Toyota", Model = "Camry", Year = 2020 },
            new Car { CarId = 2, Make = "Honda", Model = "Accord", Year = 2021 },
        };

        _carEvents = new List<CarEvent>()
        {
            new CarEvent { CarEventId = 1, CarId = 1, EventId = 1, Car = _cars[0], Event = _events[0] },
            new CarEvent { CarEventId = 2, CarId = 2, EventId = 2, Car = _cars[1], Event = _events[1] },
        };

        _cars[0].Loggers = new List<Logger> { new Logger { LoggerId = 1, CarId = 1 } };
        _cars[1].Loggers = new List<Logger> { new Logger { LoggerId = 2, CarId = 2 } };*/
        _cars = new List<Car>
        {
            new Car
            {
                CarId = 1,
                Make = "Toyota",
                Model = "Camry",
                Year = 2020,
                TeleGeneration = "5G",
                Miles = 15000,
                Location = "San Francisco",
                SourceId = 10,
                UserId = "1"
            },
            // Add more Cars
        };

        _events = new List<Event>
        {
            new Event
            {
                Id = 1,
                CarId = 1,
                EventTypeId = 1,
                UserId = "1",
                Date = DateTime.Now,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(1),
                Type = "Test event",
                Category = 1.0,
                Car = _cars[0]
            },
            // Add more Events
        };

        _carEvents = new List<CarEvent>
        {
            new CarEvent
            {
                CarEventId = 1,
                CarId = 1,
                EventId = 1,
                Car = _cars[0],
                Event = _events[0]
            },
            // Add more CarEvents
        };

        // Linking Entities Together
        _cars[0].Loggers = new List<Logger> { new Logger { CarId = 1, LogTime = DateTime.Now, LogText = "Car Created" } };
        _events[0].EventDetails = new List<EventDetail> { new EventDetail { EventId = 1, EventDetailText = "Event Detail Text" } };
        _events[0].UserEvents = new List<UserEvent> { new UserEvent { EventId = 1, UserId = "1" } };
        _cars[0].CarStaticDetail = new CarStaticDetail { CarId = 1 };
        _cars[0].Loggers = new List<Logger> { new Logger { CarId = 1, LogTime = DateTime.Now, LogText = "Car Created" } };
        _events[0].CarEvents = new List<CarEvent> { _carEvents[0] };
    }


    public async Task<IEnumerable<Car>> GetAllCars()
    {
        return await Task.FromResult(_cars);
    }

    public async Task<Car> GetCarById(int id)
    {
        var car = _cars.FirstOrDefault(c => c.CarId == id);
        return await Task.FromResult(car);
    }

    public async Task AddCar(Car car)
    {
        car.CarId = _cars.Max(c => c.CarId) + 1;
        _cars.Add(car);
        await Task.CompletedTask;
    }

    public async Task UpdateCar(Car car)
    {
        var index = _cars.FindIndex(c => c.CarId == car.CarId);
        if (index != -1)
        {
            _cars[index] = car;
        }
        await Task.CompletedTask;
    }

    public async Task DeleteCar(int id)
    {
        var car = _cars.FirstOrDefault(c => c.CarId == id);
        if (car != null)
        {
            _cars.Remove(car);
        }
        await Task.CompletedTask;
    }

    public Task Add_(Car car)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AssignUserTo_(int carId, string userId, DateTime startTime, DateTime endTime)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AssignUserTo_(int carId, string userId)
    {
        throw new NotImplementedException();
    }

    public Task Update_(Car car)
    {
        throw new NotImplementedException();
    }

    public Task Delete_(Car car)
    {
        throw new NotImplementedException();
    }

    public Task DeleteById_(int carId)
    {
        throw new NotImplementedException();
    }

    public Task Delete_(int carId)
    {
        throw new NotImplementedException();
    }

    public Task<Car> GetById_(int carId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetAll_()
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetAll_(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<CarDto>> GetAllDto_()
    {
        throw new NotImplementedException();
    }

    public Task<List<CarDto>> GetAllDtoByUserId_(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetLocation_(int carId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCount_()
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetByLocationSortedByUser_(string location)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetByMake_(string make)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetByYearRange_(int startYear, int endYear)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetByTeleGenerationSortByMilesDescending_(string teleGeneration)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetByLocationAndMake_(string location, string make)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetAllWithStaticDetails_()
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetByUserId_(string userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMileage_(int carId, int mileage)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
