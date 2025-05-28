namespace VideoGameLibrary.Flyweight
{
    public class VideoGameSharedData
    {
        public string Rating { get; }
        public string Platform { get; }

        public VideoGameSharedData(string rating, string platform)
        {
            Rating = rating;
            Platform = platform;
        }
    }
}
