using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _cinemaService;
        public CinemasController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }
        //public IActionResult Index()
        //{
        //    var model = new CinemaViewModel()
        //    {
        //        Cinemas = _cinemaService.GetAll()
        //    };
        //    return View(model);

        //}
    }
}
