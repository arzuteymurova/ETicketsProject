using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        //public IActionResult Index()
        //{
        //    var model = new MovieViewModel()
        //    {
        //        Movies = _movieService.GetAll()
        //    };
        //    return View(model);
        //}
    }
}
