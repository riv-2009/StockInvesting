using Microsoft.AspNetCore.SignalR;
using RestSharp;
using WordFinder.Models;
using WordFinder.Controllers;

namespace WordFinder.Hubs
{
    public class WordHub: Hub<IWordHubClient>
    {
        public static int count = 0;
        public async Task NumPlayers(string username)
        {
            count++;
            await Clients.All.NumPlayersCount(count, username);
        }
    }
}
