using VideoGameLibrary.Factories;
using VideoGameLibrary.Iterator;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Interfaces
{
    public interface IDataAccessLayer
    {
        VideoGameFactory factory { get; }

        IEnumerable<VideoGame> GetGames();

        void AddGame(VideoGame game);

        void RemoveGame(int? id);

        VideoGame? GetGame(int? id);

		void UpdateGame(VideoGame game);

        IVideoGameIterator GetGenreIterator(string genre);

        IVideoGameIterator GetPlatformIterator(string platform);
    }
}
