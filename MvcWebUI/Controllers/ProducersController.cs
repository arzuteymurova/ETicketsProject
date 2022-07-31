using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService _producerService;
        public ProducersController(IProducerService producerService)
        {
            _producerService = producerService;
        }
        //public IActionResult Index()
        //{
        //    var model = new ProducerViewModel()
        //    {
        //        Producers = _producerService.GetAll()
        //    };
        //    return View(model);

        //}
    }
}
