using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre es obligatorio")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public required string Telefono { get; set; }

        [Required(ErrorMessage = "El Celular es obligatorio")]
        public required string Celular { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        public required string Email { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
