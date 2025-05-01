using System.ComponentModel.DataAnnotations;

namespace Examen_P1.Models
{
    public class Dueño
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public float Presupuesto { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public Boolean EsMayorEdad 
        {
            get
            {
                return (DateTime.Now.Year - FechaNacimiento.Year) >= 18;
            }
        }

        public string MolinaM { get; set; }
    }
}
