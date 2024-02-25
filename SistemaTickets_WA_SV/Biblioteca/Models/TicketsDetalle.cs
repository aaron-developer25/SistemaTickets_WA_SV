using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class TicketsDetalle
    {
        [Key]
        public int Id { get; set; }

        public int TicketId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Emisor {  get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Mensaje { get; set; }

        public TicketsDetalle() { }

        public TicketsDetalle(int id, string emisor, string mensaje)
        {
            Id = id;
            Emisor = emisor;
            Mensaje = mensaje;
        }

    }
}
