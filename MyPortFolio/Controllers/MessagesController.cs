using Microsoft.AspNetCore.Mvc;
using MyPortFolio.Data;
using MyPortFolio.Models;

namespace MyPortFolio.Controllers
{
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly EmailSender _emailSender;

        public MessagesController(ApplicationDbContext db, EmailSender emailSender)
        {
            _db = db;
            _emailSender = emailSender;
        }

        // Display Contact Form
        public IActionResult Contact()
        {
            return View();
        }

        // Handle form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Messages message)
        {
            if (ModelState.IsValid)
            {
                message.Status = DateTime.Now;

                _db.Messages_TBL.Add(message);
                _db.SaveChanges();

                _emailSender.SendEmail("shahasghar054@gmail.com", message.Subject, $"Message from: {message.Name}\n\n{message.Body}\n\nPhone Number: {message.PhoneNumber}");

                return RedirectToAction("ThankYou");
            }

            return View(message);
        }

        // Thank you page after submission
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
