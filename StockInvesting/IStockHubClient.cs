using StockInvesting.Hubs;

namespace StockInvesting
{
    public interface IStockHubClient
    {
        Task ReceiveMessage(string ticker);
    }
}
