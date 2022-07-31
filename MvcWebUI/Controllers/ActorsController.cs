using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _actorService;
        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }
        //public IActionResult Index()
        //{
        //    var data = new ActorViewModel()
        //    {
        //        Actors = _actorService.GetAll()
        //    };
        //    return View(data);

        //}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorService.Add(actor);
            return RedirectToAction(nameof(Index));
        }

        //public IActionResult Details(int id)
        //{
        //    var actorDetails = new ActorViewModel()
        //    {
        //        Actor = _actorService.GetById(id)
        //    };
        //    if (actorDetails == null) return View("NotFound");
        //    return View(actorDetails);
        //}
    }
}
