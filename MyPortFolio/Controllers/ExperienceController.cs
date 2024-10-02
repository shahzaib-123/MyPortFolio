using Microsoft.AspNetCore.Mvc;
using MyPortFolio.Data;
using MyPortFolio.Models;

namespace MyPortFolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExperienceController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Experience> objExperienceList = _db.Experience_TBL.ToList();

            return View(objExperienceList);
        }
    }
}
