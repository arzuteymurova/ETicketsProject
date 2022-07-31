using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
