using Microsoft.AspNetCore.Mvc;
using MyPortFolio.Data;
using MyPortFolio.Models;

namespace MyPortFolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SkillController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Skills> objSkillList = _db.Skill_TBL.ToList();
            return View(objSkillList);
        }
    }
}
