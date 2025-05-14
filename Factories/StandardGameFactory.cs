using VideoGameLibrary.Models;

namespace VideoGameLibrary.Factories
{
    public class StandardGameFactory : VideoGameFactory
    {
        public override VideoGame CreateGame(string title, int year, string platform, string genre, string esrb, string image)
        {
            return new VideoGame
            {
                Title = title,
                Year = year,
                Platform = platform,
                Genre = genre,
                ESRB = esrb,
                Image = image
            };
        }
    }
}
