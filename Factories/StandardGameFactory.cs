using VideoGameLibrary.Models;

namespace VideoGameLibrary.Factories
{
    public class StandardGameFactory : VideoGameFactory
    {
        private readonly VideoGameSharedDataFactory sharedFactory = new();

        public override VideoGame CreateGame(string title, int year, string platform, string genre, string esrb, string image)
        {
            var sharedData = sharedFactory.GetSharedData(esrb, platform);
            return new VideoGame
            {
                Title = title,
                Year = year,
                SharedData = sharedData,
                Genre = genre,
                Image = image
            };
        }
    }
}