using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.ViewModels
{
    public class RegistrarViewModel
    {
        [Required(ErrorMessage = "Ingrese un nombre de usuario.")]
        [Display(Name = "Usuario*")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre.")]
        [Display(Name = "Nombre*")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese un apellido.")]
        [Display(Name = "Apellido*")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Ingrese una contraseña válida.")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña*")]
        public string Pwd { get; set; }
        [Required(ErrorMessage = "Ingrese un email válido.")]
        [EmailAddress]
        [Display(Name = "Email*")]
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
