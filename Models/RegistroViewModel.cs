using System.ComponentModel.DataAnnotations;

namespace VoluntariosConectadosRD.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string? Apellidos { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingresa un correo válido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirma tu contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string? Confirmar { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        [Required(ErrorMessage = "La provincia es obligatoria")]
        public string? Provincia { get; set; }

        public bool Terminos { get; set; }
    }
} 
