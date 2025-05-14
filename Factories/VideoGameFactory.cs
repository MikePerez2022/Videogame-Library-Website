using VideoGameLibrary.Models;

namespace VideoGameLibrary.Factories
{
    public abstract class VideoGameFactory
    {
        public abstract VideoGame CreateGame(string title, int year, string platform, string genre, string esrb, string image);
    }
}
