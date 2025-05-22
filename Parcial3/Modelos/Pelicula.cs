using System.ComponentModel.DataAnnotations;

namespace Parcial3.Modelos
{
    public class Pelicula : Media
    {
        [Required]
        public int Duracion { get; set; }
        [Required]
        public string Idioma { get; set; }
    }
}