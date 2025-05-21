using VideoGameLibrary.Factories;
using VideoGameLibrary.Interfaces;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Data
{
    public class GameCollectionDAL : IDataAccessLayer
    {
        public static VideoGameFactory factory = new StandardGameFactory();
        private static List<VideoGame> GameList = new List<VideoGame>()
        {
            factory.CreateGame("Halo 3", 2007, "PC", "FPS", "M", "https://m.media-amazon.com/images/M/MV5BMzliYzFjMTMtYWQ2Zi00ZGQ1LWJjYTUtNzI3ZGY1NzUxZTMyXkEyXkFqcGdeQXVyNTgyNTA4MjM@._V1_FMjpg_UX1000_.jpg"),
            factory.CreateGame("Skrim", 2011, "PC", "Action RPG", "M", "https://upload.wikimedia.org/wikipedia/en/1/15/The_Elder_Scrolls_V_Skyrim_cover.png"),
            factory.CreateGame("Fallout New Vegas", 2010, "PC", "Open World, Action RPG, FPS, Third person shooter", "M", "https://upload.wikimedia.org/wikipedia/en/3/34/Fallout_New_Vegas.jpg"),
            factory.CreateGame("Fallout 4", 2015, "Xbox One", "Open World, Action RPG, FPS, Third person shooter", "M", "https://image.api.playstation.com/vulcan/ap/rnd/202009/2500/D59jxQR99Jg545NKa4Nu1FmP.png"),
            factory.CreateGame("Titanfall 2", 2016, "Xbox One", "FPS, Adventure, Platform", "M", "https://upload.wikimedia.org/wikipedia/en/1/13/Titanfall_2.jpg")
        };

        VideoGameFactory IDataAccessLayer.factory => factory;

        public void AddGame(VideoGame game)
        {
            GameList.Add(game);
        }

        public VideoGame? GetGame(int? id)
        {
            VideoGame? foundMovie = GameList.Where(x => x.Id == id).FirstOrDefault();
            //if (foundMovie == null) ;
            return foundMovie;
        }

		public IEnumerable<VideoGame> GetGames()
        {
            return GameList;
        }

        public void RemoveGame(int? id)
        {
            VideoGame? foundGame = GetGame(id);
            if(foundGame != null)
            {
                GameList.Remove(foundGame);
            }
        }

        public void UpdateGame(VideoGame game)
        {
            int i;
            i = GameList.FindIndex(x => x.Id == game.Id);
			if (i != -1) GameList[i] = game;
        }
    }
}
