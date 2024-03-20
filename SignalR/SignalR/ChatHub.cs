using Microsoft.AspNetCore.SignalR;

namespace SignalR;

public sealed class ChatHub: Hub
{
    public override async Task OnConnectedAsync()
    {
        await this.Clients.All.SendAsync("ReceivedMessages", $"{Context.ConnectionId} has been joined");
    }
}