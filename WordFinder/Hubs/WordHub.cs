using Microsoft.AspNetCore.SignalR;
using RestSharp;
using WordFinder.Models;
using WordFinder.Controllers;

namespace WordFinder.Hubs
{
    public class WordHub: Hub<IWordHubClient>
    {
        public async Task PlayerTaken(string player)
        {
            player = "hello from signalr";
            await Clients.All.PlayerTakenMessage(player);
        }
    }
}
