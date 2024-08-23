using Microsoft.AspNetCore.Mvc;
using HojaDeVida.Models;
using System;
using System.Collections.Generic;

namespace HojaDeVida.Controllers
{
    public class HomeController : Controller
    {
        // Instancia del modelo que se usará en toda la aplicación
        private static ResumeViewModel resume = new ResumeViewModel
        {
            Name = "Andres Salinas",
            PhotoUrl = "/images/photo.jpg",  // Asegúrate de tener una foto en esta ruta
            PhotoSize = 30,  // Tamaño inicial en píxeles
            BirthDate = new DateTime(1990, 1, 1),
            Experiences = new List<string> { "Primera experiencia", "Segunda experiencia" }
        };

        // Acción para la vista principal
        public IActionResult Index()
        {
            // Pasar la instancia del modelo a la vista
            return View(resume);
        }

        // Acción para añadir una nueva experiencia
        [HttpPost]
        public IActionResult AddExperience(string newExperience)
        {
            if (!string.IsNullOrEmpty(newExperience))
            {
                resume.Experiences.Add(newExperience);
            }
            return RedirectToAction("Index");
        }
        public IActionResult PagDos()
        {
            return View();
        }

    }
}
