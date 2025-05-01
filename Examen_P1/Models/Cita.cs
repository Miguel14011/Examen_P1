using System.ComponentModel.DataAnnotations.Schema;

namespace Examen_P1.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaCita { get; set; }
        public int Motivo { get; set; }
        public string Tarifa
        {
            get
            {
                if (Motivo == 30)
                {
                    return "Vacunacion";
                }
                else if (Motivo == 20)
                {
                    return "Revision general";
                }
                else if (Motivo == 100)
                {
                    return "Cirugia";
                }
                else
                {
                    return "No se ha definido el motivo";
                }
            }
        }
        public int IdDueño { get; set; }

        [ForeignKey("IdDueño")]
        public Dueño? Dueño { get; set; } // Relación con la clase Dueño
    }
}
