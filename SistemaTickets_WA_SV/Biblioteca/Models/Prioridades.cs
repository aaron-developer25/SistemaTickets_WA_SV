using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Descripcion { get; set; }

        [Range(1, 31, ErrorMessage = "El valor debe estar entre (1 - 31)")]
        public int DiasCompromiso { get; set; }
    }
}
