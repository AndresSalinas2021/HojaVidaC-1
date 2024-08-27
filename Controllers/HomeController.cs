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
            var model = resume; // Devolver el modelo actual
            return View(model);
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

        // Accion que nos reiniciara los datos almacenados
        [HttpPost]
        public IActionResult Reset(string resetCode)
        {
            if (resetCode == "1234")
            {
                resume = new ResumeViewModel
                {
                    Name = "Andres Salins",
                    PhotoUrl = "/images/photo.jpg",
                    PhotoSize = 30,
                    BirthDate = new DateTime(1997, 7, 7),
                    Experiences = new List<string> { "Primera experiencia", "Segunda experiencia" }
                };
            }
            return RedirectToAction("Index");
        }

        public IActionResult PagDos()
        {
            return View();
        }

    }
}
