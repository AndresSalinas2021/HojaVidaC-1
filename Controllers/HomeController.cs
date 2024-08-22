using Microsoft.AspNetCore.Mvc;
using HojaDeVida.Models;
using System;

namespace HojaDeVida.Controllers
{
    public class HomeController : Controller
    {
        private static ResumeViewModel resume = new ResumeViewModel
        {
            Name = "Tu Nombre",
            PhotoUrl = "/images/photo.jpg",  // Asegúrate de tener una foto en esta ruta
            PhotoSize = 30,
            BirthDate = new DateTime(1990, 1, 1),
            Experiences = new List<string> { "Primera experiencia", "Segunda experiencia" }
        };

        public IActionResult Index()
        {
            return View(resume);
        }

        [HttpPost]
        public IActionResult AddExperience(string newExperience)
        {
            if (!string.IsNullOrEmpty(newExperience))
            {
                resume.Experiences.Add(newExperience);
            }
            return RedirectToAction("Index");
        }
    }
}
