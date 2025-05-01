using System.ComponentModel.DataAnnotations;

namespace Examen_P1.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Años { get; set; }
        public int IdDueño { get; set; }

        [ForeignKey("IdDueño")]
        public Dueño? Dueño { get; set; } // Relación con la clase Dueño
    }
}
