﻿using System.ComponentModel.DataAnnotations;

namespace Parcial3.Modelos
{
    public class Media
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int Lanzamiento { get; set; }
        [Required]
        public string Tipo { get; set; }
    }
}