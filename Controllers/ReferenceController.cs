using Microsoft.AspNetCore.Mvc;
using HojaDeVida.Models;
using System.Collections.Generic;

namespace HojaDeVida.Controllers
{
    public class ReferenceController : Controller
    {
        private static List<string> references = new List<string>
        {
            "Referencia 1: Juan Pérez, profesor de la Universidad ."
        };

        public IActionResult Index()
        {
            return View(references);
        }

        [HttpPost]
        public IActionResult AddReference(string newReference)
        {
            if (!string.IsNullOrEmpty(newReference))
            {
                references.Add(newReference);
            }
            return RedirectToAction("Index");
        }
    }
}
