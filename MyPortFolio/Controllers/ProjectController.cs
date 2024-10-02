using Microsoft.AspNetCore.Mvc;
using MyPortFolio.Data;
using MyPortFolio.Models;

namespace MyPortFolio.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProjectController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Projects> objProjectList = _db.Project_TBL.ToList();
            return View(objProjectList); 
        }
    }
}
