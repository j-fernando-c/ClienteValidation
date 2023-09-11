using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautySoft.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Estado es obligatorio")]
        [Display(Name = "Estado")]
        public bool estado { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string Telefono { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "La Contraseña es obligatoria")]
        [Display(Name = "Contraseña")]

        public string Contraseña { get; set; }

        [Required(ErrorMessage = "La Confirmación de la Contraseña es obligatoria")]
        [Display(Name = "Confirmar Contraseña")]
        public string ConfirmarContraseña { get; set; }
    }
}
