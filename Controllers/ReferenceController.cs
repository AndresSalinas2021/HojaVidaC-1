using Microsoft.AspNetCore.Mvc;
using HojaDeVida.Models;
using System.Collections.Generic;

namespace HojaDeVida.Controllers
{
    public class ReferenceController : Controller
    {
        // Lista estática de referencias
        private static List<string> references = new List<string>
        {
            "Referencia 1: Juan Pérez, profesor de la Universidad ."
        };
        // Acción para mostrar la lista de referencias
        public IActionResult Index()
        {
            return View(references);
        }
        // Acción para agregar una nueva referencia
        [HttpPost]
        public IActionResult AddReference(string newReference)
        {
            if (!string.IsNullOrEmpty(newReference))
            {
                references.Add(newReference);
            }
            return RedirectToAction("Index");
        }
        // Acción para reiniciar las referencias y otros datos del modelo
        [HttpPost]
        public IActionResult Reset(string resetCode)
        {
            if (resetCode == "1234")
            {
                // Restablecer la lista de referencias a su estado inicial
                references = new List<string>
                {
                    "Referencia 1: Juan Pérez, profesor de la Universidad."
                };                
            }
            return RedirectToAction("Index");
        }
    }
}
