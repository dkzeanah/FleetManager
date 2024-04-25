/* Provides a consistent gap between items */
//loggers = (await LoggerService.GetAllLoggerAsync()).ToList();
// Fetch all loggers
// Filter loggers based on CarId
// for now, set it to null // This can be adjusted later when you decide on a default value
//example expclusion- loggers = allLoggers.Where(l => l.TypeLogger != Logger.LoggerType.BluePirate && l.TypeLogger != Logger.LoggerType.BluePirateRapid).ToList();
//();
// for UI feedback
// for displaying a message to the user
// Resetting properties after successful addition
// Reset to a default or meaningful value
// Provide feedback to the user
// Handle any exceptions that may have occurred
#DraggableItemComponent.razor
   /*void ResizeMouseDown(MouseEventArgs e)
   {
       resizing = true;
       initialX = e.ClientX;
       initialY = e.ClientY;
       initialWidth = currentWidth;
       initialHeight = currentHeight;
   }
   void ResizeMouseUp(MouseEventArgs e)
   {
       resizing = false;
   }
   async void ResizeMouseMove(MouseEventArgs e)
   {
       if (resizing)
       {
           var dx = e.ClientX - initialX;
           var dy = e.ClientY - initialY;
           currentWidth = initialWidth + dx;
           currentHeight = initialHeight + dy;
           await JSRuntime.InvokeVoidAsync("setResize", currentWidth, currentHeight, Self);
       }
   }
   void MouseDown(MouseEventArgs e)
   {
       dragging = true;
       initialX = (e.ClientX - xOffset);
       initialY = (e.ClientY - yOffset);
   }
   void MouseUp(MouseEventArgs e)
   {
       initialX = currentX;
       initialY = currentY;
       dragging = false;
   }
   async void MouseMove(MouseEventArgs e)
   {
       if (dragging)
       {
           currentX = (e.ClientX - initialX);
           currentY = (e.ClientY - initialY);
           xOffset = currentX;
           yOffset = currentY;

           await JSRuntime.InvokeVoidAsync("setTranslate", currentX, currentY, Self);
       }
   }*/
//============draggableitemcomponent.razor
@*
@inject IJSRuntime JSRuntime
<div class="myDraggableItem">
    <div class="toolbar" style="width: 100%; height: 10px; background-color: gray; cursor: move;">
        <button class="deleteButton" style="width: 10px; height: 10px;">x</button>
    </div>
    <div class="content" style="width: 100%; height: 90px; background-color: red;"></div>
    <div class="resizeHandle" style="width: 10px; height: 10px; position: absolute; bottom: 0; right: 0; cursor: nwse-resize;"></div>
</div>


<div class="myDraggableItem"
     style="width: 100px; height: 100px; position: absolute; background-color: @Color;"
     data-id="@Id"
     @ref=Self
     @onmousedown="MouseDown"
     @onmousemove="MouseMove"
     @onmouseup="MouseUp">

    <div class="resizeHandle"
         style=" style="width: 10px; height: 11px; position: absolute; right: 01; bottom: 02; cursor: nwse-resize;" 
         @onmousedown="ResizeMouseDown"
         @onmousemove="ResizeMouseMove"
         @onmouseup="ResizeMouseUp">
    </div>
</div>

@code {
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Color { get; set; }

    ElementReference Self;
    bool dragging = false;
    double initialX, initialY, currentX, currentY, xOffset, yOffset;
    double initialWidth, initialHeight, currentWidth, currentHeight;
    bool resizing = false;

    void ResizeMouseDown(MouseEventArgs e)
    {
        resizing = true;
        initialX = e.ClientX;
        initialY = e.ClientY;
        initialWidth = currentWidth;
        initialHeight = currentHeight;
    }

    void ResizeMouseUp(MouseEventArgs e)
    {
        resizing = false;
    }

    async void ResizeMouseMove(MouseEventArgs e)
    {
        if (resizing)
        {
            var dx = e.ClientX - initialX;
            var dy = e.ClientY - initialY;

            currentWidth = initialWidth + dx;
            currentHeight = initialHeight + dy;

            await JSRuntime.InvokeVoidAsync("setResize", currentWidth, currentHeight, Self);
        }
    }

    void MouseDown(MouseEventArgs e)
    {
        dragging = true;
        initialX = (e.ClientX - xOffset);
        initialY = (e.ClientY - yOffset);
    }

    void MouseUp(MouseEventArgs e)
    {
        initialX = currentX;
        initialY = currentY;
        dragging = false;
    }

    async void MouseMove(MouseEventArgs e)
    {
        if (dragging)
        {
            currentX = (e.ClientX - initialX);
            currentY = (e.ClientY - initialY);
            xOffset = currentX;
            yOffset = currentY;

            await JSRuntime.InvokeVoidAsync("setTranslate", currentX, currentY, Self);
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("initDraggableItem", Self);
        }
    }
}
*@
@*
<div class="myDraggableItem"
     style="width: 100px; height: 100px; position: absolute; background-color: @Color;"
     data-id="@Id"
     @ref=Self
     @onmousedown="@MouseDown"
     @onmousemove="@MouseMove"
     @onmouseup="@MouseUp">

    <div class="resizeHandle"
         style="width: 10px; height: 10px; position: absolute; right: 0; bottom: 0; cursor: nwse-resize;"
         @onmousedown="@ResizeMouseDown"
         @onmousemove="@ResizeMouseMove"
         @onmouseup="@ResizeMouseUp">
    </div>
</div>

    <div class="toolbar"
         @onmousedown:="@MouseDown"
         @onmousemove:="@MouseMove"
         @onmouseup:="@MouseUp"
         style="width: 100%; height: 10px; background-color: gray; cursor: move;">
        <button class="deleteButton" style="width: 10px; height: 10px;">x</button>
    </div>
    <div class="content" style="width: 100%; height: 80px; background-color: @Color;"></div>
    <div class="resizeHandle"
         @onmousedown:="@ResizeMouseDown"
         @onmousemove:="@ResizeMouseMove"
         @onmouseup:="@ResizeMouseUp"
         style="width: 10px; height: 10px; position: absolute; right: 0; bottom: 0; cursor: nwse-resize;">
    </div>

<button @onclick="ToggleMode">@((IsResizeMode ? "Switch to Move Mode" : "Switch to Resize Mode"))</button>

<div class="myDraggableItem2"
     style="width: 100px; height: 100px; position: absolute; background-color: @Color;"
     data-id="@Id"
     @ref=Self
     @onmousedown="(IsResizeMode ? (Action<MouseEventArgs>)null : (Action<MouseEventArgs>)MouseDown)"
     @onmousemove="(IsResizeMode ? (Action<MouseEventArgs>)null : (Action<MouseEventArgs>)MouseMove)"
     @onmouseup="(IsResizeMode ? (Action<MouseEventArgs>)null : (Action<MouseEventArgs>)MouseUp)">

    <div class="resizeHandle2"
         style="width: 10px; height: 10px; position: absolute; right: 0; bottom: 0; cursor: nwse-resize;"
         @onmousedown="(IsResizeMode ? (Action<MouseEventArgs>)ResizeMouseDown : (Action<MouseEventArgs>)null)"
         @onmousemove="(IsResizeMode ? (Action<MouseEventArgs>)ResizeMouseMove : (Action<MouseEventArgs>)null)"
         @onmouseup="(IsResizeMode ? (Action<MouseEventArgs>)ResizeMouseUp : (Action<MouseEventArgs>)null)">
    </div>
</div>*@


@* @if (isDayTasksModalOpen)

{

    <div class="modal">

        <div class="modal-content">

            <span class="close" @onclick="CloseDayTasks">&times;</span>

            <h2>Tasks for day: @selectedDay</h2>



            @foreach (var user in users)

            {

                <div>

                    @user.UserName

                    <button @onclick="() => AddTaskForUser(user)" class="btn btn-sm btn-secondary ml-2">Add Task</button>

                </div>

            }

        </div>

    </div>

} *@


// protected override async Task OnInitializedAsync()
// {
//     await StartConnectionAsync();
// }
// private async Task StartConnectionAsync()
// {
//     var hubConnection = new HubConnectionBuilder()
//         .WithUrl("/updateHub")
//         .Build();

//     hubConnection.On<string>("ReceiveMessage", (updateMessage) =>
//     {
//         message = updateMessage;
//         StateHasChanged();
//     });

//     await hubConnection.StartAsync();
// }


// private async Task CreateSquare()
// {
//     string squareId = $"square{_squareCount++}";
//     var squareReference = await _interopModule.InvokeAsync<IJSObjectReference>("createSquare", squareId);
//     Console.WriteLine($"Created square with ID: {squareId}");  // Debugging

//     await _interopModule.InvokeVoidAsync("addButtonsToSquare", squareId);
//     Console.WriteLine("Added buttons to square");

//     await Task.Delay(2000);
//     await _interopModule.InvokeVoidAsync("changeColor", squareId, "red");
//     Console.WriteLine("Changed square color");
// }

// private async Task UpdateChartData(List<int> newData)
// {
//     await _chart.InvokeVoidAsync("updateData", newData);
// }

// private async Task ApplyChartTransformation(string transformation)
// {
//     await _chart.InvokeVoidAsync("applyTransformation", transformation);
// }