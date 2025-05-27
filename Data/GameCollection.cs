using VideoGameLibrary.Factories;
using VideoGameLibrary.Interfaces;
using VideoGameLibrary.Iterator;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Data
{
    public class GameCollection : IDataAccessLayer
    {
        public VideoGameFactory factory => throw new NotImplementedException();

        public void AddGame(VideoGame game)
        {
            throw new NotImplementedException();
        }

        public VideoGame? GetGame(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VideoGame> GetGames()
        {
            throw new NotImplementedException();
        }

        public IVideoGameIterator GetGenreIterator(string genre)
        {
            throw new NotImplementedException();
        }

        public IVideoGameIterator GetPlatformIterator(string platform)
        {
            throw new NotImplementedException();
        }

        public void RemoveGame(int? id)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(VideoGame game)
        {
            throw new NotImplementedException();
        }
    }
}
