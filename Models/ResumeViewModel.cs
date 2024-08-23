using System;
using System.Collections.Generic;

namespace HojaDeVida.Models
{
    public class ResumeViewModel
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int PhotoSize { get; set; }  // Tamaño inicial de la foto en píxeles
        public DateTime BirthDate { get; set; }
        public List<string> Experiences { get; set; }

        public ResumeViewModel()
        {
            Experiences = new List<string>();
            Name = string.Empty; // Inicializar con un valor por defecto
            PhotoUrl = string.Empty; // Inicializar con un valor por defecto
        }
    }
}
