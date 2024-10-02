using Microsoft.AspNetCore.Mvc;
using MyPortFolio.Data;
using MyPortFolio.Models;

namespace MyPortFolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EducationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Education> objEducationList = _db.Education_TBL.ToList();

            return View(objEducationList);
        }
    }
}
