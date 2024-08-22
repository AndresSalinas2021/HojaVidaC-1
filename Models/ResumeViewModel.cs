using System;
using System.Collections.Generic;

namespace HojaDeVida.Models
{
    public class ResumeViewModel
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        //public int PhotoSize { get; set; }

        public int PhotoSize { get; set; } = 100; // Tamaño inicial de la foto en píxeles
        public DateTime BirthDate { get; set; }
        public List<string> Experiences { get; set; }

        public ResumeViewModel()
        {
            Experiences = new List<string>();
            Name = string.Empty; // O algún valor por defecto
            PhotoUrl = string.Empty; // O algún valor por defecto
        }
    }
}
