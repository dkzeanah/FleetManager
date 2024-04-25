/*using BlazorApp1.CarModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp1.Pages
{
    public partial class Calendar : ComponentBase
    {
        private void LogProperties()
        {
            Console.WriteLine($"_interopModule: {_interopModule}");
            Console.WriteLine($"SelectedUser: {selectedUser}");
            Console.WriteLine($"CurrentUser: {currentUser}");
            Console.WriteLine($"Users Count: {users.Count}");
            Console.WriteLine($"NewTaskModel: {newTaskModel}");
            Console.WriteLine($"TaskModels Count: {taskModels.Count}");
            Console.WriteLine($"SelectedTask: {selectedTask}");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"SelectedDay: {selectedDay}");
            Console.WriteLine($"SquareCount: {_squareCount}");
            Console.WriteLine($"FirstRender: {firstRender}");
            Console.WriteLine($"IsDayTasksModalOpen: {isDayTasksModalOpen}");
            Console.WriteLine($"IsGroupDayTasksModalOpen: {isGroupDayTasksModalOpen}");
            Console.WriteLine($"IsUserDayTasksModalOpen: {isUserDayTasksModalOpen}");
            Console.WriteLine($"IsTaskModalOpen: {isTaskModalOpen}");
            Console.WriteLine($"CurrentMonth: {currentMonth}");
            Console.WriteLine($"CurrentDate: {CurrentDate}");
            Console.WriteLine($"SelectedDate: {selectedDate}");
            Console.WriteLine($"CalendarDays Count: {calendarDays.Count}");
        }

        // Call this method whenever you change any of the variables.
        // E.g., in a button click event or any other event handler.
        private void OnChange()
        {
            LogProperties();
        }

        private IJSObjectReference _interopModule;
        // private IJSObjectReference _chart;

        private ApplicationUser? selectedUser = new ApplicationUser(); // Initialize to a default value
        private ApplicationUser? currentUser = new ApplicationUser();               //{ get; set; }
        private List<ApplicationUser> users = new List<ApplicationUser>();


        private TaskModel newTaskModel = new TaskModel();
        private List<TaskModel> taskModels = new List<TaskModel>();
        private TaskModel selectedTask;



        private string? message;
        private int selectedDay;
        private int _squareCount = 0;

        private bool firstRender = true;
        private bool isDayTasksModalOpen = false;
        private bool isGroupDayTasksModalOpen = false;
        private bool isUserDayTasksModalOpen = false;
        private bool isTaskModalOpen = false;

        private DateTime currentMonth = DateTime.Now; //should remove
        private DateTime CurrentDate = DateTime.Now; // Declare the DateTime property
        public DateTime selectedDate { get; set; } = DateTime.Now;
        //DateTime currentMonth = DateTime.Now;
        List<DateTime> calendarDays = new List<DateTime>();

        void UpdateCalendarDays()

        {

            calendarDays.Clear();



            // Get the first day of the month

            var firstDayOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);



            // Calculate how many days to add from the previous month

            int daysFromPreviousMonth = (int)firstDayOfMonth.DayOfWeek;



            // Add days from the previous month

            for (int i = daysFromPreviousMonth - 1; i >= 0; i--)

            {

                calendarDays.Add(firstDayOfMonth.AddDays(-i - 1));

            }



            // Add days of the current month

            var daysInCurrentMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);

            for (int i = 0; i < daysInCurrentMonth; i++)

            {

                calendarDays.Add(firstDayOfMonth.AddDays(i));

            }



            // Add days from the next month to complete the grid

            var totalCells = 42; // 6 weeks x 7 days

            int daysFromNextMonth = totalCells - calendarDays.Count;

            for (int i = 0; i < daysFromNextMonth; i++)

            {

                calendarDays.Add(firstDayOfMonth.AddDays(daysInCurrentMonth + i));

            }

        }
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
        private void CloseDayTasks()
        {
            isDayTasksModalOpen = false;
            isGroupDayTasksModalOpen = false;  // Ensure that both are closed
        }
        private void OpenDayTasks(int day)
        {
            Console.WriteLine($"OpenDayTasks triggered for day {day}"); // Logging
            selectedDay = day;
            isDayTasksModalOpen = true;
        }


        //OnInitialized gets complete list of - users
        //


        private void MoveToNextMonth()
        {
            CurrentDate = CurrentDate.AddMonths(1);
            Console.WriteLine($"Current Date: {CurrentDate}");
            UpdateCalendarDays();

            StateHasChanged();
        }

        private void MoveToPreviousMonth()
        {
            CurrentDate = CurrentDate.AddMonths(-1);
            Console.WriteLine($"Current Date: {CurrentDate}");

            UpdateCalendarDays();

            StateHasChanged();
        }
        protected override async Task OnInitializedAsync()
        {
            //string currentUserId = await UserService.GetCurrentUserIdAsync();
            //ApplicationUser currentUser = await UserService.GetUserByIdAsync(currentUserId);
            users = await UserService.GetAllUsersAsync();
            var taskModels = await TaskModelService.GetAllTaskModels();
            OnChange();
        }
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
                // Handle invalid day
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
                logger.LogError($"An error occurred: {ex.Message}");
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


        private void CloseDayTasks2()
        {
            isDayTasksModalOpen = false;
            isGroupDayTasksModalOpen = false;  // Ensure that both are closed    
        }
        private void CloseGroupDayTasks()
        {
            isGroupDayTasksModalOpen = false;
        }



        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                this.firstRender = false;
                _interopModule = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./interop.js");
                Console.WriteLine("Interop module imported");
                // Initialize your chart here if needed
                // _chart = await _interopModule.InvokeAsync<IJSObjectReference>("createChart", element, initialData);
            }
        }
        private async Task CreateSquare()
        {
            string squareId = $"square{_squareCount++}";
            var squareReference = await _interopModule.InvokeAsync<IJSObjectReference>("createSquare", squareId);
            Console.WriteLine($"Created square with ID: {squareId}");  // Debugging
            await _interopModule.InvokeVoidAsync("addButtonsToSquare", squareId);
            Console.WriteLine("Added buttons to square");
            await Task.Delay(2000);
            await _interopModule.InvokeVoidAsync("changeColor", squareId, "red");
            Console.WriteLine("Changed square color");
        }



        void OnDateSelected(DateTime date)

        {



        }

        void OnFormat(string format)

        {

        }
        
    }

}
*/