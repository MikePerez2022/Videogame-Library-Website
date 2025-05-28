using VideoGameLibrary.Flyweight;

namespace VideoGameLibrary.Factories
{
    public class VideoGameSharedDataFactory
    {
        private readonly Dictionary<string, VideoGameSharedData> sharedDataPool = new();

        public VideoGameSharedData GetSharedData(string rating, string platform)
        {
            string key = $"{rating}_{platform}";

            if (!sharedDataPool.ContainsKey(key))
            {
                sharedDataPool[key] = new VideoGameSharedData(rating, platform);
            }

            return sharedDataPool[key];
        }
    }
}
