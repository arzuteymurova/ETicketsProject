using Business.Abstract;
using Business.Concrete;
using Core.Helpers;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class MovieImagesController : Controller
    {
        IMovieImageService _movieImageService;
        public MovieImagesController(IMovieImageService movieImageService)
        {
            _movieImageService = movieImageService;
        }

        //public IActionResult Index()
        //{
        //    var images = new MovieImageViewModel()
        //    {
        //       // MovieImages = _movieImageService.GetMovieImages(3).Data
        //    };
        //    return View(images);
        //}
    }
}
