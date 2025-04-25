using VideoGameLibrary.Models;

namespace VideoGameLibrary.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<VideoGame> GetGames();

        void AddGame(VideoGame game);

        void RemoveGame(int? id);

        VideoGame? GetGame(int? id);

		void UpdateGame(VideoGame game);
    }
}
