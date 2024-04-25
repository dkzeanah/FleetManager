using Microsoft.AspNetCore.SignalR;

public class MyMiddleware
{
    private readonly IHubContext<UpdateHub> _hubContext;

    public MyMiddleware(IHubContext<UpdateHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // your logic here

        await _hubContext.Clients.All.SendAsync("ReceiveMessage", "Your message");
    }
}