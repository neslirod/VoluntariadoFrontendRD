using System.ComponentModel.DataAnnotations;

namespace VoluntariosConectadosRD.Models
{
    public class RegistroONGViewModel
    {
        [Required(ErrorMessage = "El nombre de la ONG es obligatorio")]
        public string? NombreONG { get; set; }

        [Required(ErrorMessage = "El RNC es obligatorio")]
        public string? RNC { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingresa un correo válido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "El representante es obligatorio")]
        public string? Representante { get; set; }

        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Provincia { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El sector es obligatorio")]
        public string? Sector { get; set; }

        public string? LogoONG { get; set; }
        public bool Terminos { get; set; }
    }
} 
