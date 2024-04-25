using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

[ApiController]
[Route("api/[controller]")]
public class UpdateController : ControllerBase
{
    private readonly IHubContext<UpdateHub> _hubContext;

    public UpdateController(IHubContext<UpdateHub> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendUpdate(string message)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveMessage", message);
        return Ok();
    }
}