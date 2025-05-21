using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using VideoGameLibrary.Data;
using VideoGameLibrary.Interfaces;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Controllers
{
    public class VideoGameController : Controller
    {
        IDataAccessLayer dal = new GameCollectionDAL();

        public IActionResult Index()
        {
            return View();
        }

		//[Route("Add")]
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(VideoGame g)
		{
			if (ModelState.IsValid)
			{
                var game = dal.factory.CreateGame(
					g.Title,
					g.Year,
					g.Platform,
					g.Genre,
					g.ESRB,
					g.Image
				);

                dal.AddGame(g);
				return RedirectToAction("Collection", "VideoGame");
			}
			return View();
		}

		[HttpGet] //loading the edit page
		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				ViewData["Error"] = "Game id not found.";
				return View();
			}
			else
			{
				VideoGame? g = dal.GetGame(id);
				if (g == null)
				{
					ViewData["Error"] = "Cannot find Game with id provided";
				}
				return View(g);
			}
		}

		[HttpPost]
		public IActionResult Edit(VideoGame g)
		{
			if(ModelState.IsValid)
			{
				dal.UpdateGame(g);
				TempData["success"] = "Game updated";
				return RedirectToAction("Collection", "VideoGame");
			}
			else
			{
				return View();
			}
		}

		public IActionResult Delete(int? id)
		{
			if (id == null) return NotFound();

			dal.RemoveGame(id);

			TempData["success"] = "Game deleted!";
			return RedirectToAction("Collection", "VideoGame");
		}

		public IActionResult Collection()
        {
            return View(dal.GetGames());
        }

		[Route("Game")]
		public IActionResult DisplayGame()
		{
			VideoGame g = new VideoGame();
			return View(g);
		}

		[HttpPost]
		public IActionResult Loan(int? id, string? name)
		{
			VideoGame? game = dal.GetGame(id);
			if (game == null) return NotFound();

			game.LoanedTo = name;			
			game.LoanDate = DateOnly.FromDateTime(DateTime.Today);
			dal.UpdateGame(game);

			return RedirectToAction("Collection", "VideoGame");
		}

		[HttpPost]
		public IActionResult Return(int? id)
		{
			VideoGame? game = dal.GetGame(id);

			if (game == null) return NotFound();

			game.LoanedTo = null;
			game.LoanDate = null;

			return RedirectToAction("Collection", "VideoGame");
		}


		[HttpPost]
		public IActionResult Search(string? key)
		{
			if (string.IsNullOrEmpty(key))
			{
				return View("Collection", dal.GetGames());
			}

			return View("Collection", dal.GetGames().Where(x => x.Title.ToLower().Contains(key.ToLower())));
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

		private readonly ILogger<VideoGameController> _logger;

		public VideoGameController(ILogger<VideoGameController> logger)
		{
			_logger = logger;
		}
	}
}
