//@using System.Globalization
//@using System.ComponentModel.DataAnnotations
//@using BlazorApp1.Data
//@using Microsoft.AspNetCore.Components.Rendering

//@inject IJSRuntime jsRuntime
//@inject IUserService UserService
//@inject ITaskModelService TaskModelService
//@inject AuthenticationStateProvider AuthenticationStateProvider
//@inject IDbContextFactory<ApplicationDbContext> DbContextFactory
//@inject ILogger<Calendar2Component> Logger

//<style>
//    .debug-section {
//        padding: 10px;
//background - color: #f0f0f0;
//        border - bottom: 1px solid #ddd;
//        font-family: monospace;
//color: #333;
//    }

//    .calendar - day.in-range {
//    background - color: #c0e0f0; /* Color to indicate selected range */
//    }

//    .calendar {
//        border: 1px solid #ddd;
//        padding: 10px;
//width: 300px;
//    }

//    .toolbar {
//        display: flex;
//justify - content: space - between;
//margin - bottom: 10px;
//    }

//    .calendar - header {
//display: grid;
//    grid - template - columns: repeat(7, 1fr);
//    text - align: center;
//}

//    .calendar - days {
//display: grid;
//    grid - template - columns: repeat(7, 1fr);
//    text - align: center;
//}

//    .calendar - day {
//padding: 5px;
//border: 1px solid #eee;
//    }

//    .range - picker {
//    margin - top: 10px;
//display: flex;
//    justify - content: space - between;
//}

//        .range - picker input {
//            margin-right: 5px;
//        }

//    .toolbar {
//        display: flex;
//justify - content: space - around;
//align - items: center;
//padding: 10px 0;
//background - color: #f4f4f4;
//        border - radius: 5px;
//box - shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
//    }

//        .toolbar > * {
//margin: 0 5px;
//}

//        .toolbar select,
//        .toolbar input[type="text"],
//        .toolbar input[type = "color"],
//        .toolbar input[type="date"]
//{
//padding: 5px;
//border: 1px solid #ccc;
//            border - radius: 5px;
//    line - height: 1.5;
//}

//        .toolbar button
//{
//    padding: 5px 10px;
//    border: none;
//    border-radius: 5px;
//    cursor: pointer;
//    background-color: #007bff;
//            color: white;
//}

//            .toolbar button:hover {
//                background-color: #0056b3;
//            }

//    .calendar - day {
//display: flex;
//position: relative;
//    /* Other styles for day cells */
//}

//    .task - range - strip {
//position: absolute;
//width: 100 %;
//height: 100 %;
//opacity: 0.5; /* Adjust for desired transparency */
//    z - index: 1; /* Below the text */
//}

//    .task - text {
//    z - index: 2; /* Above the strip */
//display: grid;
//    align - items: center;
//    justify - content: center;
//    text - align: center;
//    /* Other styles for text */
//}

//</ style >

//@if(_isCollapsed)
//{
//    < button @onclick = "ToggleCollapse" > Expand </ button >
//}
//else
//{

//    < div class= "toolbar" >
//        < button @onclick = "PreviousMonth" >←</ button >
//        < span > @_currentMonth.ToString("MMMM yyyy") </ span >
//        < button @onclick = "NextMonth" >→</ button >



//        < select @bind = "_userToEdit" >
//            < option value = "" > Select User </ option >
//            @foreach(var user in users)
//            {
//                < option value = "@user.Id" > @user.FriendlyName </ option >
//            }
//        </ select >
//        @*should put user.FriendlyName in calendar block *@
//        <button @onclick="SetUserForSelectedDay">Add User to Day</button>
//        @* Should add text to a block, setting the user.friendlyname as the last choses, or first in the list if not - but also with available mechanism to change it afterthefact *@
//        <input type="text" @bind="_inputForSelectedDay" placeholder="Enter text" />
//        @* I think should create a dictionary to ApplicationUser instead of a string value like before *@
//        <input type="color" @bind="_colorToAssign" />
//        @* Input used to work here, but now, this should basically be 1/2 of the addtaskrange method i.e. the TaskModel.Task being the 'string' input. *@
//        <button @onclick="ApplyInputToSelectedDay">Apply Text</button>
//        <button @onclick="ChangeUserColor">Change Color</button>

//        @if (_selectedRangeStart.HasValue && _selectedRangeEnd.HasValue)
//        {
//            <button @onclick="DeleteSelectedRange">Delete Range</button>
//            <button @onclick="UngroupSelectedRange">Ungroup Range</button>
//        }

//        < button @onclick = "ShowRangePicker" > Add Range </ button >
//        < button @onclick = "ToggleCollapse" > Collapse </ button >
//    </ div >

//    @RenderCalendar()


//    @if(_showRangePicker)
//    {
//        < div class= "range-picker" >
//            < input type = "date" @bind = "_rangeStart" />
//            < input type = "date" @bind = "_rangeEnd" />
//            < select @bind = "newTaskModel.UserId" >
//                < option value = "" > Select User </ option >
//                @foreach(var user in users)
//                {
//                    < option value = "@user.Id" > @user.UserName </ option >
//                }
//            </ select >
//            < input type = "text" @bind = "newTaskModel.Task" placeholder = "Task Description" />
//            < button @onclick = "AddTaskRange" > Add Task </ button >
//        </ div >
//    }

//}




//@code {

//    private DateTime _rangeStart;
//private DateTime _rangeEnd;
//private string _taskDescription;
//private string _selectedUserId;

//private List<ApplicationUser> users = new List<ApplicationUser>();
//private ApplicationUser selectedUser;



//private List<TaskModel> taskModels = new List<TaskModel>();
//private TaskModel newTaskModel = new TaskModel();
//private TaskModel selectedTask;

//protected override async Task OnInitializedAsync()
//{
//    users = await UserService.GetAllUsersAsync();
//    taskModels = await TaskModelService.GetAllTaskModels();
//}

//private DateTime _currentMonth = DateTime.Today;
//private DateTime? _selectedDay;

//private Dictionary<DateTime, string> _dayTexts = new Dictionary<DateTime, string>();

//private bool _isCollapsed = false;
//private bool _showRangePicker = false;
//private List<(DateTime start, DateTime end)> _ranges = new();
//private DateTime? _selectedRangeStart;
//private DateTime? _selectedRangeEnd;
//private Dictionary<DateTime, List<string>> _dayUsers = new Dictionary<DateTime, List<string>>();
////this should be a list of ApplicationUser now, no so much hard coded
//private List<string> _users = new List<string> { "Andreas", "Shannon", "Lamar", "Marty", "Tim", "Donovan", "Nathaniel", "Hendrik", "Charlie", "Sawyer" };
////these should be remapped to utilize the ApplicationUser object, for each one existing, give it a color.
//private Dictionary<string, string> _userColors = new Dictionary<string, string>
//{
//    {"Andreas", "red"},
//    {"Shannon", "green"},
//    {"Lamar", "blue"},
//    {"Marty", "orange"},
//    {"Tim", "purple"},
//    {"Donovan", "cyan"},
//    {"Nathaniel", "magenta"},
//    {"Hendrik", "yellow"},
//    {"Charlie", "pink"},
//    {"Sawyer", "brown"}
//};

//private string _userToEdit;
//private string _colorToAssign;
//private string _inputForSelectedDay;
//// private TaskModel _inputForSelectedDay;

//private void ApplyInputToSelectedDay()
//{
//    //This was my original way to add text to a calendar day, but ultimately decided it was too limited as only one existed per day. Now, AddTaskRange method should accomplish this and more...
//    //only it kind of does, since it still doesnt add multiple 'entries' per day, just gives one longer string of data the more added..
//    if (!string.IsNullOrEmpty(_inputForSelectedDay))
//    {
//        if (_selectedDay.HasValue)
//        {

//            _dayTexts[_selectedDay.Value] = _inputForSelectedDay;
//            Logger.LogInformation($"Added text to {_selectedDay.Value.ToShortDateString()}: {_inputForSelectedDay}");
//        }
//        else if (_selectedRangeStart.HasValue && _selectedRangeEnd.HasValue)
//        {
//            for (DateTime date = _selectedRangeStart.Value; date <= _selectedRangeEnd.Value; date = date.AddDays(1))
//            {
//                _dayTexts[date] = _inputForSelectedDay;
//            }
//            Logger.LogInformation($"Added text to range from {_selectedRangeStart.Value.ToShortDateString()} to {_selectedRangeEnd.Value.ToShortDateString()}: {_inputForSelectedDay}");
//        }
//        _inputForSelectedDay = "";
//    }
//}

//private void ChangeUserColor()
//{
//    //This method used to work, when adding the simple user list of string to the calendar. I like how it worked, but i cannot get it to work with the list of ApplicationUser the same way.
//    if (!string.IsNullOrWhiteSpace(_userToEdit) && !string.IsNullOrWhiteSpace(_colorToAssign))
//    {
//        if (_userColors.ContainsKey(_userToEdit))
//        {
//            _userColors[_userToEdit] = _colorToAssign;
//        }
//        else
//        {
//            Logger.LogWarning($"User {_userToEdit} not found in colors dictionary. Adding the user with the specified color.");
//            _userColors.Add(_userToEdit, _colorToAssign);
//        }
//    }
//}
//private void SetUserForSelectedDay()
//{
//    //i have since moved away from a simple dictionary list of users to using an actual ApplicationUser which is an extension of IdentityUser. Furthermore, along with leveraging this user type, TaskModel object also contains the ApplicationUser, so its used within that aswell.

//    //this should basically be one half of the addtaskrange method and utilizing its relevant entities/models (ie ApplicationUser)
//    if (!string.IsNullOrEmpty(_userToEdit) && _selectedDay.HasValue)
//    {
//        if (!_dayUsers.ContainsKey(_selectedDay.Value))
//            _dayUsers[_selectedDay.Value] = new List<string>();

//        if (!_dayUsers[_selectedDay.Value].Contains(_userToEdit))
//        {
//            _dayUsers[_selectedDay.Value].Add(_userToEdit);
//            Logger.LogInformation($"Added user {_userToEdit} for {_selectedDay.Value.ToShortDateString()}");
//        }
//    }
//}
//private void AddRange()
//{
//    //this method is left over from before I chose to encapsulate a range by having the properties in a TaskModel object - which can have the ranges, as wanted, but also account for what user and text to go along with those ranges...
//    /*
//     * i.e   public class TaskModel
//    {
//public int Id { get; set; }
//public DateTime DateAssigned { get; set; } = DateTime.Now;
//[Required]
//public string Task { get; set; }
//public bool IsComplete { get; set; } = false;


//public virtual ApplicationUser? User { get; set; }// = null!;
//public string? UserId { get; set; }
//public string? UserName { get; set; }
//// New properties for task ranges
//public DateTime? RangeStart { get; set; }
//public DateTime? RangeEnd { get; set; }



//public int? Importance { get; set; }

//public DateTime? DateCompleted { get; set; }
//public DateTime? DateExpired { get; set; }
//}
//*/
//    _ranges.Add((_rangeStart, _rangeEnd));
//    Logger.LogInformation($"Added range: {_rangeStart.ToShortDateString()} - {_rangeEnd.ToShortDateString()}");
//    _showRangePicker = false;
//}
////above this line doesnt work / irrelevant code
//private async Task AddTaskRange()
//{
//    if (string.IsNullOrEmpty(newTaskModel.UserId))
//    {
//        // Handle the case where no user is selected
//        Logger.LogInformation("no user selected");
//        newTaskModel.UserId = "3de00zzz - 2828 - 0000 - 0000 - 3de000000000";
//        newTaskModel.User = await UserService.GetUserByIdAsync("3de00zzz-2828-0000-0000-3de000000000");
//        Console.WriteLine($"set {newTaskModel.UserId} and {newTaskModel.User} for User");
//        return;
//    }
//    Console.WriteLine($" {newTaskModel.UserId} and {newTaskModel.User} for User");

//    newTaskModel.RangeStart = _rangeStart;
//    newTaskModel.RangeEnd = _rangeEnd;
//    taskModels.Add(newTaskModel); // Add to local list for immediate UI update
//    await TaskModelService.AddTaskModelAsync(newTaskModel); // Persist to service or database
//    newTaskModel = new TaskModel(); // Reset for next input
//    RefreshCalendar();

//}
//private void RefreshCalendar()
//{
//    Console.WriteLine("RefreshCalendar Method");
//    StateHasChanged();
//}
//private void ShowRangePicker()
//{
//    // add method to delete from an already 'picked' range.

//    _rangeStart = DateTime.Today;
//    _rangeEnd = DateTime.Today.AddDays(3);
//    _showRangePicker = true;
//}



//private void OnDayClick(DateTime day)
//{
//    var tasksForDay = taskModels.Where(task => day >= task.RangeStart && day <= task.RangeEnd);

//    // Check if the day is part of a range
//    var range = _ranges.FirstOrDefault(r => day >= r.start && day <= r.end);
//    if (range.start != default)
//    {
//        _selectedRangeStart = range.start;
//        _selectedRangeEnd = range.end;
//        Logger.LogInformation($"Day in range clicked: {day.ToShortDateString()} in range {range.start.ToShortDateString()} to {range.end.ToShortDateString()}");

//    }
//    else
//    {
//        _selectedDay = day; // If it's not part of a range, select the day
//        Logger.LogInformation($"Day clicked: {day.ToShortDateString()}");

//    }
//    // Check if the clicked day has any tasks and take necessary actions
//    // For example, activating the task input field for editing
//}

//private void DeleteSelectedRange()
//{
//    if (_selectedRangeStart.HasValue && _selectedRangeEnd.HasValue)
//    {
//        _ranges.Remove(_ranges.First(r => r.start == _selectedRangeStart.Value && r.end == _selectedRangeEnd.Value));
//        _selectedRangeStart = null;
//        _selectedRangeEnd = null;
//    }
//}






//private void DeleteSelectedRange2()
//{
//    if (_selectedRangeStart.HasValue && _selectedRangeEnd.HasValue)
//    {
//        var datesToRemove = _dayUsers.Keys
//                                     .Where(date => date >= _selectedRangeStart.Value && date <= _selectedRangeEnd.Value)
//                                     .ToList();

//        foreach (var date in datesToRemove)
//        {
//            _dayUsers.Remove(date);
//        }

//        _selectedRangeStart = null;
//        _selectedRangeEnd = null;
//        Logger.LogInformation("Selected range deleted");
//    }
//}

//private void UngroupSelectedRange()
//{
//    if (_selectedRangeStart.HasValue && _selectedRangeEnd.HasValue)
//    {
//        _selectedRangeStart = null;
//        _selectedRangeEnd = null;
//        Logger.LogInformation("Selected range ungrouped");
//    }
//}


//private void ToggleCollapse()
//{
//    _isCollapsed = !_isCollapsed;
//    Logger.LogInformation($"Calendar collapsed status: {_isCollapsed}");
//}





//private void PreviousMonth()
//{
//    _currentMonth = _currentMonth.AddMonths(-1);
//    Logger.LogInformation($"Navigated to {_currentMonth.ToString("MMMM yyyy")}");
//}

//private void NextMonth()
//{
//    _currentMonth = _currentMonth.AddMonths(1);
//    Logger.LogInformation($"Navigated to {_currentMonth.ToString("MMMM yyyy")}");
//}


//private RenderFragment RenderCalendar() => builder =>
//{
//    int seq = 0; // Reset sequence number for each rendering

//    // Debug section
//    builder.OpenElement(seq++, "div");
//    builder.AddAttribute(seq++, "class", "debug-section");
//    if (!string.IsNullOrEmpty(_userToEdit))
//    {
//        builder.AddContent(seq++, $"Latest User: {_userToEdit}");
//        if (_userColors.TryGetValue(_userToEdit, out var color))
//        {
//            builder.AddContent(seq++, $" | Color: {color}");
//        }
//    }
//    if (_selectedDay.HasValue)
//    {
//        builder.AddContent(seq++, $" | Selected Day: {_selectedDay.Value.ToShortDateString()}");
//    }
//    builder.CloseElement();

//    // Calendar header
//    RenderCalendarHeader(builder, ref seq);

//    // Calendar days
//    RenderCalendarDays(builder, ref seq);
//};

//private void RenderCalendarHeader(RenderTreeBuilder builder, ref int seq)
//{
//    var daysInMonth = DateTime.DaysInMonth(_currentMonth.Year, _currentMonth.Month);
//    var startDayOfMonth = new DateTime(_currentMonth.Year, _currentMonth.Month, 1).DayOfWeek;
//    var dayOffset = (int)startDayOfMonth - (int)DayOfWeek.Monday;
//    dayOffset = dayOffset < 0 ? 7 + dayOffset : dayOffset;

//    builder.OpenElement(seq++, "div");
//    builder.AddAttribute(seq++, "class", "calendar-header");
//    for (int i = 0; i < 7; i++)
//    {
//        builder.OpenElement(seq++, "div");
//        builder.AddContent(seq++, CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)((i + (int)DayOfWeek.Monday) % 7)));
//        builder.CloseElement();
//    }
//    builder.CloseElement();
//}
//private string _debugMessage = "";

//private void UpdateDebugMessage(string message)
//{
//    _debugMessage = message;
//    StateHasChanged(); // Ensure UI updates with new debug message
//}
//private void RenderCalendarDays(RenderTreeBuilder builder, ref int seq)
//{
//    var daysInMonth = DateTime.DaysInMonth(_currentMonth.Year, _currentMonth.Month);
//    var startDayOfMonth = new DateTime(_currentMonth.Year, _currentMonth.Month, 1).DayOfWeek;
//    var dayOffset = (int)startDayOfMonth - (int)DayOfWeek.Monday;
//    dayOffset = dayOffset < 0 ? 7 + dayOffset : dayOffset;

//    builder.AddContent(seq++, $"Debug Info: {_debugMessage}");

//    builder.OpenElement(seq++, "div");
//    builder.AddAttribute(seq++, "class", "calendar-days");

//    // Render calendar days
//    builder.OpenElement(0, "div");
//    builder.AddAttribute(1, "class", "calendar-days");

//    int dayCounter = 1;
//    for (int cell = 0; cell < daysInMonth + dayOffset; cell++)
//    {
//        DateTime currentDate = new DateTime(_currentMonth.Year, _currentMonth.Month, dayCounter);
//        var tasksForDay = taskModels.Where(task => currentDate >= task.RangeStart && currentDate <= task.RangeEnd).ToList();

//        builder.OpenElement(2, "div");
//        builder.AddAttribute(3, "class", "calendar-day");

//        // If the day cell is not empty
//        if (cell >= dayOffset)
//        {
//            currentDate = new DateTime(_currentMonth.Year, _currentMonth.Month, dayCounter);
//            builder.AddAttribute(8, "onclick", EventCallback.Factory.Create(this, () => OnDayClick(currentDate)));
//            // Render the background strip for tasks
//            foreach (var task in tasksForDay)
//            {
//                // Calculate the number of days in the range and text segment
//                int rangeDays = ((task.RangeEnd ?? currentDate) - (task.RangeStart ?? currentDate)).Days + 1;
//                string userColor = _userColors.TryGetValue(task.UserId ?? string.Empty, out var color) ? color : "black";

//                // Create a strip with the task color
//                builder.OpenElement(4, "div");
//                builder.AddAttribute(5, "class", "task-range-strip");
//                builder.AddAttribute(6, "style", $"background-color: {userColor};");
//                builder.CloseElement();

//                // Calculate text segment only if the task's start date matches the current date
//                if (task.RangeStart == currentDate)
//                {
//                    // Render the task text once, positioned to cover the entire range
//                    builder.OpenElement(7, "div");
//                    builder.AddAttribute(8, "class", "task-text");
//                    builder.AddAttribute(9, "style", $"color: {userColor}; grid-column-start: span {rangeDays};");
//                    builder.AddContent(10, task.Task);
//                    builder.CloseElement();
//                }
//            }

//            // Render day number
//            builder.AddContent(11, currentDate.Day.ToString());
//            dayCounter++;
//        }
//        else
//        {
//            // Render empty cell
//            builder.AddAttribute(12, "class", "calendar-day empty");
//        }

//        builder.CloseElement(); // Close the day cell
//    }

//    builder.CloseElement(); // Close the calendar days containe
//    builder.CloseElement(); // Close the calendar days containe



//}

//private void RenderDayCell(RenderTreeBuilder builder, ref int seq, DateTime currentDate, int dayCounter)
//{
//    var tasksForDay = taskModels.Where(task => currentDate >= task.RangeStart && currentDate <= task.RangeEnd).ToList();

//    foreach (var user in _users)
//    {
//        var userTasks = tasksForDay.Where(task => task.UserId == user).ToList();
//        if (userTasks.Any())
//        {
//            string userColor = _userColors.TryGetValue(user, out var color) ? color : "black";
//            float segmentHeight = 100f / _users.Count;

//            builder.OpenElement(seq++, "div");
//            builder.AddAttribute(seq++, "class", "task-range-strip");
//            builder.AddAttribute(seq++, "style", $"background-color: {userColor}; height: {segmentHeight}%; top: {segmentHeight * _users.IndexOf(user)}%;");

//            foreach (var task in userTasks)
//            {
//                if (task.RangeStart == currentDate)
//                {
//                    builder.OpenElement(seq++, "span");
//                    builder.AddAttribute(seq++, "class", "task-text");
//                    builder.AddAttribute(seq++, "style", $"color: white;");
//                    builder.AddContent(seq++, task.Task);
//                    builder.CloseElement();
//                }
//            }

//            builder.CloseElement();
//        }
//    }

//    // Render day number
//    builder.AddContent(seq++, dayCounter.ToString());
//}



//}