using ticketsMvcg.Data;
using ticketsMvcg.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de pelicula")]
        [Required(ErrorMessage = "Nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "Descripcion de pelicula")]
        [Required(ErrorMessage = "Descripcion es requerida")]
        public string Description { get; set; }

        [Display(Name = "Precio en $")]
        [Required(ErrorMessage = "Precio es requerido")]
        public double Price { get; set; }

        [Display(Name = "URL de poster")]
        [Required(ErrorMessage = "Url de poster es requerido")]
        public string ImageURL { get; set; }

        [Display(Name = "Fecha de inicio de pelicula")]
        [Required(ErrorMessage = "Fecha de inicio es requerida")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de finalizacion")]
        [Required(ErrorMessage = "Fecha de finalizacion es requerida")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Seleccione categoria")]
        [Required(ErrorMessage = "Categoria de pelicula es requerida")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Seleccione actores")]
        [Required(ErrorMessage = "Actores de pelicula son requeridos")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Seleccione sala")]
        [Required(ErrorMessage = "Sala de pelicula es requerida")]
        public int CinemaId { get; set; }

        [Display(Name = "Seleccione productor")]
        [Required(ErrorMessage = "Productor de pelicula es requerido")]
        public int ProducerId { get; set; }
    }
}
