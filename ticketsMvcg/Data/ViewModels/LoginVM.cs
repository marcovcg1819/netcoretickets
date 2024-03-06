using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Correo requerido")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
