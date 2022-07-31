using WordFinder.Hubs;

namespace WordFinder
{
    public interface IWordHubClient
    {
        Task PlayerTakenMessage(string player);
    }
}
