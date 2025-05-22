using System.ComponentModel.DataAnnotations;

namespace Parcial3.Modelos
{
    public class Videojuego : Media
    {
        [Required]
        public string Plataforma { get; set; }
        [Required]
        public int Peso { get; set; }
    }
}