using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;



namespace Football.Models
{
    public class Teams
    {
        /*
        [Required]
        [Display(Name = "Id equipo")]

        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Id Liga")]

        public int league { get; set; }

        [Required]
        [Display(Name = "Temporada")]

        public int season { get; set; }

        [Required]
        [Display(Name = "País")]

        public string country { get; set; }

        [Required]
        [Display(Name = "Código")]

        public string code { get; set; }

        [Required]
        [Display(Name = "Evento")]

        public int venue { get; set; }
        [Required]
        [Display(Name = "Búsqueda")]

        public string search { get; set; }

        public int TeamId { get; set; } // Propiedad para el identificador del equipo seleccionado
        public List<SelectListItem> TeamsIdList { get; set; }
        public Teams TeamInfo { get; set; }
        public int SelectedNumber { get; set; }
        */
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string country { get; set; }
        public int founded { get; set; }
        public bool national { get; set; }
        public string logo { get; set; }
        public int selectedNumber { get; set; }
        public bool HasSearched { get; set; }
    }
}