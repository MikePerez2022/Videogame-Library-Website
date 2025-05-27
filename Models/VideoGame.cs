using System.ComponentModel.DataAnnotations;

namespace VideoGameLibrary.Models
{
	public class VideoGame
	{
		private static int nextId = 0;
		public int? Id { get; set; } = nextId++;

		[Required(ErrorMessage ="Game Title is Required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Release year is Required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Game platform is Required")]
        public string? Platform { get; set; }

        [Required(ErrorMessage = "Game genre is Required")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "Game esrb rating is Required")]
        public string? ESRB { get; set; }

        [Required(ErrorMessage = "Game image is Required")]
        public string? Image { get; set; }

		public string? LoanedTo { get; set; }
		public DateOnly? LoanDate { get; set; }

		public VideoGame() { }
	}
}
