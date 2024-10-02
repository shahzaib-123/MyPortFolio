using Microsoft.AspNetCore.Mvc;

namespace MyPortFolio.Controllers
{
    public class PodcastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
