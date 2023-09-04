using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Football.Models
{
    public class Countries
    {


        [Required]
        [Display(Name = "Nombre")]

        public string name { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string code { get; set; }

        [Required]
        [Display(Name = "Bandera")]

        public string flag { get; set; }


    }
}