using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe contener solo letras.")]
        public string? Nombres { get; set; }

        [Required(ErrorMessage = "Debe indicar un numero teléfonico.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "La longitud debe ser de 10 dígitos")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El numero teléfonico solo lleva dígitos.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Debe indicar el numero de celular")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "La longitud debe ser de 10 dígitos")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El numero de celular solo lleva digitos.")]
        public string? Celular { get; set; }

        [Required(ErrorMessage = "Debe indicar el RNC")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El RNC solo lleva dígitos.")]
        public string? RNC { get; set; }

        [Required(ErrorMessage = "Debe indicar un correo electronico")]
        [EmailAddress(ErrorMessage = "Este correo electronico no es valido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Debe indicar una direccion")]
        public string? Direccion { get; set; }
    }
}
