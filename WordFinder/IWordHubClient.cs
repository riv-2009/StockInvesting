using WordFinder.Hubs;

namespace WordFinder
{
    public interface IWordHubClient
    {
        Task NumPlayersCount(int count, string username);
    }
}
