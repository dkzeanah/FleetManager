using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services;

namespace xUnit
{
    public class CarServiceTests
    {
        private readonly CarService _carService;
        private readonly ICarRepository _carRepository;
        private readonly IEventService _eventService;
        private readonly IUserService _userService;
        private readonly ICarDetailRepository _carDetailRepository;

        public CarServiceTests()
        {
            // Assuming these are simple enough to be instantiated
            // Otherwise you might want to create a simple stub that implements the interface
            _carRepository = new CarRepository();
            _eventService = new EventService();
            _userService = new UserService();
            _carDetailRepository = new CarDetailRepository();

            _carService = new CarService(_carRepository, _eventService, _userService, _carDetailRepository);
        }

        [Fact]
        public async Task GetCarByIdAsync_ReturnsCorrectCar()
        {
            // Arrange
            var carId = 1;
            var car = new Car { CarId = carId, Model = "Test" };
            await _carRepository.AddCarAsync(car);

            // Act
            var result = await _carService.GetCarByIdAsync(carId);

            // Assert
            result.ShouldBe(car);
        }

        [Fact]
        public async Task AddCarAsync_AddsCarCorrectly()
        {
            // Arrange
            var car = new Car { CarId = 1, Model = "Test" };

            // Act
            await _carService.AddCarAsync(car);

            // Assert
            var result = await _carService.GetCarByIdAsync(car.CarId);
            result.ShouldBe(car);
        }

        // Similarly, you can write tests for other methods
    }


}