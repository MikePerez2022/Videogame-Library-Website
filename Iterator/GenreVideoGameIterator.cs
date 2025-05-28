using VideoGameLibrary.Models;

namespace VideoGameLibrary.Iterator
{
    public class GenreVideoGameIterator : IVideoGameIterator
    {
        private readonly List<VideoGame> filteredGames;
        private int ind = 0;

        public GenreVideoGameIterator(IEnumerable<VideoGame> games, string genre)
        {
            filteredGames = games.Where(g => g.Genre == genre).ToList();
        }

        public bool HasNext() => ind < filteredGames.Count;

        public VideoGame Next() => filteredGames[ind++];
    }
}
