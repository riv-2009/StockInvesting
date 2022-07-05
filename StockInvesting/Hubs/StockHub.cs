using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using RestSharp;
using StockInvesting.Models;
using StockInvesting.Controllers;

namespace StockInvesting.Hubs
{
    public class StockHub: Hub<IStockHubClient>
    {
        public async Task StockTickerMessage(string message)
        {
            //randomDay.GetRandomDay()
            //Returns a random day between (august 1, 2020 and febuary 5, 2022)
            RandomDay randomDay = new RandomDay();
            DateTime date = randomDay.GetRandomDay();

            string url = $"https://api.polygon.io/v2/aggs/ticker/" +
                $"{message.ToUpper()}/range/1/day/{date.ToString("yyyy-MM-dd")}/" +
                $"{date.AddDays(10).ToString("yyyy-MM-dd")}?apiKey=IIrxKiZhCrJaV0LKZpUVYatFWopiLbxO";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = await client.GetAsync(request);

            message = response.Content;

            await Clients.All.ReceiveMessage(message);
        }
    }
}
