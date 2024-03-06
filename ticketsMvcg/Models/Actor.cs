using ticketsMvcg.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage = "Foto de perfil es requerida")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "Nombre completo es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre completo debe tener entre 3 y 50 caracteres")]
        public string FullName { get; set; }

        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "Biografia es requerida")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
