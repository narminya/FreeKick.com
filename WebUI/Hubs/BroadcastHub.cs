using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Hubs
{
    public class BroadcastHub : Hub
    {
        public Task JoinGame(string gameId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, gameId);
        }

        public Task LeaveGame(string gameId)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, gameId);
        }
    }
}
