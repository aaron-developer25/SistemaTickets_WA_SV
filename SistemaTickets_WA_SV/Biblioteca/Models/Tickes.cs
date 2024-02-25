using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }

		[Required(ErrorMessage = "El campo fecha es obligatorio")]
		public DateTime Fecha { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Selecciona una prioridad")]
		[ForeignKey("Prioridades")]
		public int PrioridadId { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Selecciona un cliente")]
		[ForeignKey("Clientes")]
		public int ClienteId { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Selecciona un sistema")]
		[ForeignKey("Sistemas")]
		public int SistemaId { get; set; }

		[Required(ErrorMessage = "El campo solicitado por es obligatorio")]
		[RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo debe contener letras")]
		public string? Solicitadopor { get; set; }

		[Required(ErrorMessage = "El campo asunto es obligatorio")]
		public string? Asunto { get; set; }

		[Required(ErrorMessage = "El campo descripción es obligatorio")]
		public string? Descripcion { get; set; }
	}
}
