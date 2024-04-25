using BlazorApp1.CarModels;
using BlazorApp1.Components;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorApp1.Components.Pages;

namespace BlazorApp1.Components.Pages
{
    public partial class CarList121123 : ComponentBase
    {
        private IJSObjectReference _interopModule;
        private ApplicationUser? selectedUser = new ApplicationUser(); // Initialize to a default value
        private string? selectedUserString;

        private string selectedUserId;
        private ApplicationUser? currentUser = new ApplicationUser();               //{ get; set; }
        private List<ApplicationUser> users = new List<ApplicationUser>();


        private TaskModel newTaskModel = new TaskModel();
        private List<TaskModel> taskModels = new List<TaskModel>();

        private string? message;
        private int selectedDay;
        private int _squareCount = 0;

        private bool firstRender = true;
        private bool isDayTasksModalOpen = false;
        private bool isGroupDayTasksModalOpen = false;
        private bool isUserDayTasksModalOpen = false;

        private bool isCalendarVisible = true; // Initially visible

        private void ToggleCalendarVisibility()
        {
            isCalendarVisible = !isCalendarVisible;
        }
        private string GetCalendarCssClass()
        {
            return isCalendarVisible ? "calendar-visible calendar-transition" : "calendar-hidden calendar-transition";
        }
        public DateTime selectedDate { get; set; } = DateTime.Now;

        private List<TaskModel> GetTasksForSelectedUserAndDay()
        {
            // Assuming TaskModel has a DateAssigned property of type DateTime
            return taskModels.Where(t => t.UserId == selectedUser.Id && t.DateAssigned.Day == selectedDay).ToList();
        }
        private List<TaskModel> GetTasksForUser(ApplicationUser user)
        {
            return taskModels.Where(t => t.UserId == user.Id).ToList();
        }
        private void PreloadTasksForSelectedUserAndDay(int day, ApplicationUser user)
        {
            selectedDay = day;
            selectedUser = user;
            taskModels = GetTasksForSelectedUserAndDay();
        }
        private async void AddTaskForUser(ApplicationUser user)
        {
            Console.WriteLine($"Adding task for user: {user}");
            if (selectedDay > 0 && selectedDay <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                newTaskModel.UserId = user.Id;
                newTaskModel.UserName = user.FriendlyName; // Assuming FriendlyName is a property on ApplicationUser
                newTaskModel.DateAssigned = new DateTime(DateTime.Now.Year, DateTime.Now.Month, selectedDay);
                newTaskModel.Importance = 1;
                newTaskModel.DateExpired = newTaskModel.DateAssigned.AddDays(7); // One week from DateAssigned

                await TaskModelService.AddTaskModel(newTaskModel);
                taskModels = (await TaskModelService.GetAllTaskModels()).ToList(); // Refresh the task list
                newTaskModel = new TaskModel(); // Clear the input field
                StateHasChanged(); // Update the UI
            }
            else
            {
                // Handle invalid day
            }

        }
        private async void AddTaskForUser()
        {
            if (selectedDay > 0 && selectedDay <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                newTaskModel.UserId = selectedUser.Id;
                newTaskModel.UserName = selectedUser.FriendlyName; // Assuming FriendlyName is a property on ApplicationUser
                newTaskModel.DateAssigned = new DateTime(DateTime.Now.Year, DateTime.Now.Month, selectedDay);
                newTaskModel.Importance = 1;
                newTaskModel.DateExpired = newTaskModel.DateAssigned.AddDays(7); // One week from DateAssigned

                await TaskModelService.AddTaskModel(newTaskModel);
                taskModels = (await TaskModelService.GetAllTaskModels()).ToList(); // Refresh the task list
                GetTasksForSelectedUserAndDay();
                newTaskModel = new TaskModel(); // Clear the input field
                StateHasChanged(); // Update the UI
            }
            else
            {
                Console.WriteLine("Invalid if section");
            }
        }
        private void OpenDayTasksForUser(int day, ApplicationUser user)
        {
            PreloadTasksForSelectedUserAndDay(day, user);

            selectedDay = day;
            selectedUser = user;
            selectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);  // Update the selectedDate

            isGroupDayTasksModalOpen = false;  // Close group modal if open
            isDayTasksModalOpen = true;
            StateHasChanged();

        }
        private void OpenDayTasks(int day, ApplicationUser user)
        {
            selectedDay = day;
            selectedUser = user;
            selectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);  // Update the selectedDate

            isGroupDayTasksModalOpen = false;  // Close group modal if open
            isDayTasksModalOpen = true;

        }
        private void OpenDayTasksForGroup(int day)
        {
            try
            {
                selectedDay = day;
                isGroupDayTasksModalOpen = true;
                selectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);  // Update the selectedDate

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid something fd up");
            }
        }
        private void OpenDay(int day)
        {
            try
            {
                selectedDay = day;
                selectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);  // Update the selectedDate

                isGroupDayTasksModalOpen = true;  // group modal open

                isDayTasksModalOpen = false;
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occurred: {ex.Message}");
            }
        }


        private void CloseDayTasks()
        {
            isDayTasksModalOpen = false;
            isGroupDayTasksModalOpen = false;  // Ensure that both are closed
        }
        private void CloseGroupDayTasks()
        {
            isGroupDayTasksModalOpen = false;
        }

        // Show all cars with loggers
        //show all cars adas
        //show all cars by software level

        // private List<Module> modulesForSelectedCar;
        private List<Module>? modulesForSelectedCar;
        public List<Module>? modules;
        private Module newModule { get; set; } = new Module();
        private string CurrentUserName { get; set; }
        private string CurrentUserRole { get; set; }
        //private List<ApplicationUser> users = new List<ApplicationUser>();
        private List<TaskModel> taskList = new List<TaskModel>();
        private TaskModel newTask = new TaskModel();

        // Static list of Squares - not clear what this is for from the provided code.
        private static List<Square> Squares { get; set; } = new List<Square>();

        // Variables for managing state
        private bool isAssignmentCompleted = false; // Not used in the provided code
        int carIdToBeDeleted; // Potentially for identifying which car to delete
        private DateTime startDate = DateTime.Now; // Start date for assigning user to car
        private DateTime endDate; // End date for assigning user to car

        // Other various variables
        //private string selectedUser; // Selected user from the modal dropdown
        private string errorMessage = ""; // Not used in the provided code



        // Models and Lists
        Car newCar = new Car(); // Model for a new car
        private Car? selectedCar; // Car currently being viewed/edited
        private List<Car>? cars = new List<Car>(); // List of cars to display

        // Booleans for controlling UI state
        private bool showDeleteConfirmation = false;
        private bool isUserModalOpen = false;
        private bool isModalOpen = false;
        private bool isAdminOrOrganizer = false; // True if the current user is an admin or organizer
        private bool showError = false; // Not used in the code provided

        // Dictionaries for mapping between user IDs and their names
        private Dictionary<string, string> userIdToUserName; // Not used in the code provided
        private Dictionary<string, string> userIdToFriendlyName; // Not used in the code provided




        private static int methodCounter = 0;


        private string searchTerm = string.Empty;
        private bool isAddCarModalOpen = false;



        private IEnumerable<Car> filteredCars => GetFilteredCars();
        private string FormatMiles(int? miles)
        {
            // Format miles to 5 digits with leading zeros
            return miles.HasValue ? miles.Value.ToString("D5") : "00000";
        }
        private IEnumerable<Car> GetFilteredCars()
        {
            methodCounter++;
            Console.WriteLine($"Method GetFilteredCars called. Count: {methodCounter}");

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return cars;
            }
            else
            {
                searchTerm = searchTerm.ToLower();
                var searchKeywords = searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return cars.Where(car => searchKeywords.Any(keyword =>
                    (car.Make?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (car.Model?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (car.Year?.ToString().Contains(keyword) ?? false) ||
                    (car.TeleGeneration?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (car.Miles?.ToString().Contains(keyword) ?? false) ||
                    (car.Location?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (car.CarDetail?.Finas?.Contains(keyword) ?? false) ||
                    (car.CarDetail?.SoftwareVersion?.Contains(keyword) ?? false) ||
                    (car.CarDetail?.Tag?.Contains(keyword) ?? false) ||
                    (car.UserId?.Contains(keyword) == true) ||
                    (car.Loggers?.Any(logger => logger.Id.ToString().Contains(keyword) || logger.TypeLogger.ToString().Contains(keyword)) ?? false)
                // Add checks for any other properties or related objects you want to search by
                )).ToList();
            }
        }


        void DeleteCar(int carId)
        {
            try
            {
                if (!isAdminOrOrganizer)
                {
                    showError = true;
                    errorMessage = "You must be an Admin or Organizer to delete a car.";
                    return;
                }
                CarService.DeleteCarAsync(carId);
            }
            catch (Exception ex)
            {
                showError = true;
                errorMessage = $"An error occurred: {ex.Message}";
            }
        }
        void ConfirmDelete(bool confirm)
        {
            if (confirm)
            {
                CarService.DeleteCarAsync(carIdToBeDeleted);
            }

            showDeleteConfirmation = false;
        }


        private async Task LoadModulesForCar()
        {
            modulesForSelectedCar = await ModuleService.GetModulesByCarIdAsync(selectedCar.CarId);

            //modulesForSelectedCar = modules.Where(m => m.CarModules.Any(cm => cm.CarId == selectedCar.CarId)).ToList();
        }

        string ColoredDotIfTrue(bool? condition, string color, string tooltip)
        {
            return condition.HasValue && condition.Value
                ? $"<span class='dot' style='color: {color}' title='{tooltip}'>●</span>"
                : string.Empty;
        }
        string DotIfTrue(bool? condition)
        {
            return condition.HasValue && condition.Value ? "●" : string.Empty;
        }


        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            CurrentUserName = user.Identity.Name;
            try
            {
                //var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                //var user = authState.User;

                if (user.IsInRole("Admin") || user.IsInRole("Organizer"))
                {
                    isAdminOrOrganizer = true;
                }

                users = await UserService.GetAllUsersAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the cars: {ex.Message}");
            }
            finally
            {
                cars = await CarService.GetAllCarsWithDetailsAsync();
                modules = (await ModuleService.GetAllModulesAsync()).ToList();  // Assuming you have a GetAllModulesAsync method


            }

            // allUsers = await DbContext.Users.ToListAsync();
        }

        private void OpenModal(Car car)
        {

            methodCounter++;
            Console.WriteLine($"Method OpenModal called. Count: {methodCounter}");
            selectedCar = car;
            isModalOpen = true;
        }
        private void OpenUserModal(Car car)
        {
            methodCounter++;
            Console.WriteLine($"Method OpenUserModal called. Count: {methodCounter}");
            isUserModalOpen = true;

            selectedCar = car;
            startDate = DateTime.Now.Date;
            endDate = DateTime.Now.Date.AddDays(7); // Or use 7 for a week
        }
        void ToggleAddCarModal()
        {
            methodCounter++;
            Console.WriteLine($"Method ToggleAddCarModal called. Count: {methodCounter}");
            isAddCarModalOpen = true;
            //isAddCarModalOpen = !isAddCarModalOpen;
            return;
        }

        //Modals
        // References to Modal components
        private ModalComponent modal;
        private ModalComponent userModal;
        private ModalComponent addCarModal;

        //Add

        private async Task AddModule(int selectedCarId)
        {
            methodCounter++;
            Console.WriteLine($"Method AddModulel called. param: {selectedCarId} Count: {methodCounter}");
            Console.WriteLine("AddModule method from parent being passed into AddModuleComponent");
            if (ModuleService == null || newModule == null)
            {
                Console.WriteLine("");
                return;
            }
            // await ModuleService.AddModuleAsync(newModule, selectedCar.CarId); // Assuming AddModuleAsync is updated to accept CarId
            // await LoadModulesForCar(selectedCar.CarId); // Refresh the list, assuming LoadModulesForCar is updated to accept CarId

            if (string.IsNullOrEmpty(newModule.Name))
            {
                Console.WriteLine($"{newModule.Name}");
                return;
            }

            await ModuleService.AddModuleAsync(newModule); // Add the new module to the database
            newModule = new Module(); // Reset the form
            modules = await ModuleService.GetAllModulesAsync(); // Refresh the list

            if (CarService == null)
            {
                Console.WriteLine(" if carservice is null..  returning");
                return;
            }

            var selectedCar = await CarService.GetCarByIdAsync(selectedCarId);

            if (selectedCar == null)
            {
                Console.WriteLine("if selectedcar is null...");
                return;
            }

            if (selectedCar.Modules == null)
            {
                Console.WriteLine("selectedCar.Modules is null... new blank list added..");

                selectedCar.Modules = new List<Module>();
            }

            selectedCar.Modules.Add(newModule);

            await CarService.UpdateCarAsync(selectedCar);
        }

        //Get
        private ApplicationUser? GetUserByUserName(string userName)
        {
            return users.FirstOrDefault(u => u.UserName == userName || u.Email == userName);
        }


        //close -- all with method counter
        private void CloseModal()
        {
            methodCounter++;
            Console.WriteLine($"Method CloseModal called. Count: {methodCounter}");
            selectedCar = null;
            isModalOpen = false;
            StateHasChanged();
        }
        void CloseAddCarModal()
        {
            methodCounter++;
            Console.WriteLine($"Method CloseAddCarModal called. Count: {methodCounter}");
            isAddCarModalOpen = false;
            StateHasChanged();
            return;
        }
        private void CloseUserModal()
        {
            methodCounter++;
            Console.WriteLine($"Method CloseUserModal called. Count: {methodCounter}");
            if (isUserModalOpen)
            {
                isUserModalOpen = false;
                selectedUser = null;
                startDate = DateTime.Now;
                endDate = DateTime.Now;
                StateHasChanged();
            }
        }
        private async Task Refresh()
        {
            StateHasChanged();
        }

        private async Task SaveCar()
        {
            try
            {
                if (selectedCar != null && selectedCar.CarDetail != null)
                {
                    Console.WriteLine($"SaveCar method called: {selectedCar.ToString()} \n\n\n ");
                    await CarService.UpdateCarDetailAsync(selectedCar.CarDetail);
                    await CarService.UpdateCarAsync(selectedCar);

                    cars = await CarService.GetAllCarsWithDetailsAsync();
                    CloseModal();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the car: {ex.Message}");
            }

            CloseModal();
            return;
        }
        //private void SortCarsByUser() => SortCars("CurrentUser");
        //{
        //    cars = cars.OrderBy(c => c.CurrentUser).ToList();
        //}
        private void SortCarsByFinas() => SortCars("Finas");
        private void SortCarsByTeleGen() => SortCars("TeleGeneration");
        private void SortCarsByTag() => SortCars("Tag");
        private void SortCarsBySoftwareVersion() => SortCars("SoftwareVersion");
        private void SortCarsByMiles() => SortCars("Miles");
        private void SortCarsByModel() => SortCars("Model");
        private void SortCarsByLogger() => SortCars("HasLogger");
        private void SortCarsByUser() => SortCars("User");


        private void SortCars(string column)
        {
            if (!columnSortDirections.ContainsKey(column))
            {
                columnSortDirections.Add(column, true);
            }

            bool ascending = columnSortDirections[column];
            switch (column)
            {
                // ...existing cases...
                case "Finas":
                    cars = ascending ? cars.OrderBy(c => c.CarDetail.Finas).ToList() : cars.OrderByDescending(c => c.CarDetail.Finas).ToList();
                    break;
                case "Tag":
                    cars = ascending ? cars.OrderBy(c => c.CarDetail.Tag).ToList() : cars.OrderByDescending(c => c.CarDetail.Tag).ToList();
                    break;
                case "TeleGeneration":
                    cars = ascending ? cars.OrderBy(c => c.TeleGeneration).ToList() : cars.OrderByDescending(c => c.TeleGeneration).ToList();
                    break;
                case "SoftwareVersion":
                    cars = ascending ? cars.OrderBy(c => c.CarDetail.SoftwareVersion).ToList() : cars.OrderByDescending(c => c.CarDetail.SoftwareVersion).ToList();
                    break;
                case "Miles":
                    cars = ascending ? cars.OrderBy(c => c.Miles).ToList() : cars.OrderByDescending(c => c.Miles).ToList();
                    break;
                case "Model":
                    cars = ascending ? cars.OrderBy(c => c.Model).ToList() : cars.OrderByDescending(c => c.Model).ToList();
                    break;
                case "HasLogger":
                    if (ascending)
                    {
                        cars = cars.OrderBy(c => c.HasLogger.HasValue && c.HasLogger.Value ? 0 : 1)
                                   .ThenBy(c => c.LoggerId.HasValue ? 0 : 1)
                                   .ThenBy(c => c.Loggers != null && c.Loggers.Any() ? 0 : 1)
                                   .ToList();
                    }
                    else
                    {
                        cars = cars.OrderByDescending(c => c.HasLogger.HasValue && c.HasLogger.Value ? 0 : 1)
                                   .ThenByDescending(c => c.LoggerId.HasValue ? 0 : 1)
                                   .ThenByDescending(c => c.Loggers != null && c.Loggers.Any() ? 0 : 1)
                                   .ToList();
                    }
                    break;
                case "User":
                    if (ascending)
                    {
                        cars = cars.OrderBy(c => IsDummyUser(c.UserId) ? 1 : 0)
                                   .ThenBy(c => GetUserName(c.UserId))
                                   .ToList();
                    }
                    else
                    {
                        cars = cars.OrderByDescending(c => IsDummyUser(c.UserId) ? 1 : 0)
                                   .ThenByDescending(c => GetUserName(c.UserId))
                                   .ToList();
                    }
                    break;

                    // ...other cases...
            }

            columnSortDirections[column] = !ascending;
        }
        private bool IsDummyUser(string userId)
        {
            // Assuming "3de00zzz-2828-0000-0000-3de000000000" is the ID of your dummy user
            return userId == "3de00zzz-2828-0000-0000-3de000000000";
        }
        private DateTime currentMonth = DateTime.Now;
        private DateTime CurrentDate = DateTime.Now;
        private bool isAllTasksModalOpen = false;
        private bool isTaskModalOpen = false;
        private TaskModel selectedTask;


        private void OpenTaskModal(TaskModel task)
        {
            Console.WriteLine("OpenTaskModal triggered");
            selectedTask = task;
            isTaskModalOpen = true;
        }

        private List<TaskModel> GetTasksForUserAndDay(string userId, DateTime date)
        {
            return taskModels.Where(t => t.UserId == userId && t.DateAssigned.Date == date.Date).ToList();
        }

        private List<TaskModel> GetTasksForUserAndDay(ApplicationUser user, int day)
        {
            return taskModels.Where(t => t.UserId == user.Id && t.DateAssigned.Day == day).ToList();
        }
        private void OpenDayTasks(int day)
        {
            Console.WriteLine($"OpenDayTasks triggered for day {day}"); // Logging
            selectedDay = day;
            isDayTasksModalOpen = true;
            isAllTasksModalOpen = true; // Open the all tasks modal

        }
        private void MoveToNextMonth()
        {
            CurrentDate = CurrentDate.AddMonths(1);
            StateHasChanged();
        }
        private void MoveToPreviousMonth()
        {
            CurrentDate = CurrentDate.AddMonths(-1);
            StateHasChanged();
        }
        private void SortCars2(string column)
        {
            bool ascending = columnSortDirections[column];
            switch (column)
            {
                case "Finas":
                    cars = ascending ? cars.OrderBy(c => c.CarDetail.Finas).ToList() : cars.OrderByDescending(c => c.CarDetail.Finas).ToList();
                    break;
                case "Tag":
                    cars = ascending ? cars.OrderBy(c => c.CarDetail.Tag).ToList() : cars.OrderByDescending(c => c.CarDetail.Tag).ToList();
                    break;
                case "TeleGeneration":
                    cars = ascending ? cars.OrderBy(c => c.TeleGeneration).ToList() : cars.OrderByDescending(c => c.TeleGeneration).ToList();
                    break;
                case "SoftwareVersion":
                    cars = ascending ? cars.OrderBy(c => c.CarDetail.SoftwareVersion).ToList() : cars.OrderByDescending(c => c.CarDetail.SoftwareVersion).ToList();
                    break;
                case "Miles":
                    cars = ascending ? cars.OrderBy(c => c.Miles).ToList() : cars.OrderByDescending(c => c.Miles).ToList();
                    break;
                case "Model":
                    cars = ascending ? cars.OrderBy(c => c.Model).ToList() : cars.OrderByDescending(c => c.Model).ToList();
                    break;
                case "Users":
                    cars = ascending ? cars.OrderBy(c => GetUserName(c.UserId)).ToList() : cars.OrderByDescending(c => GetUserName(c.UserId)).ToList();
                    break;

            }

            columnSortDirections[column] = !ascending;
        }
        private Dictionary<string, bool> columnSortDirections = new Dictionary<string, bool>
    {
        { "Finas", true },
        { "Tag", true },
        { "TeleGeneration", true },
        { "SoftwareVersion", true },
        { "Miles", true },
        { "Model", true },
        { "User", true }

    };
        public string GetUserName(string userId)
        {
            var user = users.FirstOrDefault(u => u.Id == userId);
            return user != null ? user.FriendlyName : "Unknown User";
        }
        private void OnUserSelected(ChangeEventArgs e)
        {
            var selectedUserName = e.Value.ToString();
            selectedUser = GetUserByUserName(selectedUserName);
            methodCounter++;
            Console.WriteLine($"Method OnUserSelected called. Count: {methodCounter}. ");
            selectedUserString = selectedUser.Id.ToString();
            Console.WriteLine($"Method OnUserSelected called. selectedUserString: {selectedUserString}. ");


        }
        private async Task AssignUser()
        {
            methodCounter++;
            Console.WriteLine($"Method AssignUser called. Count: {methodCounter}");
            selectedCar.UserId = selectedUserString;
            if (selectedUserString != null && selectedCar != null)
            {
                Console.WriteLine($"{selectedUserString} is the selectedUserString (Id) tobegottenwith: email");
                var user = GetUserByUserName(selectedUserString);

                if (user != null && user.Email != null)
                {
                    Console.WriteLine($"user: {user.FriendlyName}");
                    var result = await CarService.AssignUserToCarAsync(selectedCar.CarId, user.Email, startDate, endDate);

                    if (!result)
                    {
                        Console.WriteLine("failure to assign car...");
                    }
                    Console.WriteLine($"ASSIGNED {selectedCar.CarId} to Id: {selectedCar.UserId}");
                }
                else
                {
                    Console.WriteLine("User not found or email is null");
                }
            }


            isUserModalOpen = false;
            isModalOpen = false;
            SaveCar();
            //StateHasChanged();



            StateHasChanged();
        }

    }
}
