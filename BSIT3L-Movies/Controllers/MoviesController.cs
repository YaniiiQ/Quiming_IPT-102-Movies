using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel { Id = 1, Name = "Dark Knight", Rating = "7", ReleaseYear = 2008, Genre = "Action/ Thriller",Description =" With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.",ImageSource = "/Img/darkknight.jpg", YTurl = "https://www.youtube.com/watch?v=LDG9bisJEaI",movieURL = "https://myflixerz.to/movie/the-dark-knight-19752"},
            new MovieViewModel {  Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 3, Name = "The Lord of the Rings: The Return of the King", Rating = "8", ReleaseYear = 2003, Genre = "Fantasy/Adventure" },
            new MovieViewModel { Id = 1, Name = "Forrest Gump", Rating = "7", ReleaseYear = 1994, Genre = "Romance/ Drama" },
            new MovieViewModel { Id = 1, Name = "A Quiet Place II ", Rating = "9", ReleaseYear = 2020, Genre = "Sci Fi/Thriller" },
            new MovieViewModel { Id = 1, Name = "Logan Lucky ", Rating = "4", ReleaseYear = 2017, Genre = "Crime/Comedy" },
            new MovieViewModel { Id = 1, Name = "West Side Story", Rating = "9", ReleaseYear = 2021, Genre = "Musical/Romance " },
            new MovieViewModel { Id = 1, Name = "An Education", Rating = "7", ReleaseYear = 2009, Genre = "Drama/Romance" },
            new MovieViewModel { Id = 1, Name = "It's Kind Of A Funny Story", Rating = "6", ReleaseYear = 2010, Genre = "Comedy" },
            new MovieViewModel { Id = 1, Name = "The Pirates Of The Caribbean Film Franchise", Rating = "9", ReleaseYear = 2017, Genre = "Action/ Thriller" },
            new MovieViewModel { Id = 1, Name = "Furious 7", Rating = "9", ReleaseYear = 2015, Genre = "Action/ Thriller" },
            new MovieViewModel { Id = 1, Name = "Where The Crawdads Sing ", Rating = "7", ReleaseYear = 2020, Genre = "Drama/ Thriller" },
            new MovieViewModel { Id = 1, Name = "A Better Life", Rating = "8", ReleaseYear = 2015, Genre = "Drama/ Romance" },
            new MovieViewModel { Id = 1, Name = "Dungeons & Dragons: Honor Among Thieves", Rating = "5", ReleaseYear = 2023, Genre = "Action/ Thriller" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

