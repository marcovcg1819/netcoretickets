using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "Nombre completo es requerido")]
        public string FullName { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Correo es requerido")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar password")]
        [Required(ErrorMessage = "Confirmacion de password es requerido")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "los password no son iguales")]
        public string ConfirmPassword { get; set; }
    }
}
