using ticketsMvcg.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo de sala")]
        [Required(ErrorMessage = "Logo de sala es requerido")]
        public string Logo { get; set; }

        [Display(Name = "Nombre de sala")]
        [Required(ErrorMessage = "Nombre de sala es requerido")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Descripcion de sala es requerida")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
