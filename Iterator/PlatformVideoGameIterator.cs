using VideoGameLibrary.Models;

namespace VideoGameLibrary.Iterator
{
    public class PlatformVideoGameIterator : IVideoGameIterator
    {
        private readonly List<VideoGame> filteredGames;
        private int ind = 0;

        public PlatformVideoGameIterator(IEnumerable<VideoGame> games, string platform)
        {
            filteredGames = games.Where(g => g.Platform == platform).ToList();
        }

        public bool HasNext() => ind < filteredGames.Count;

        public VideoGame Next() => filteredGames[ind++];
    }
}
