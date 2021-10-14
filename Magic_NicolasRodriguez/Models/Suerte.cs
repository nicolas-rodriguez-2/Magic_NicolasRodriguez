﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Magic_NicolasRodriguez.Models
{
    public class Suerte
    {

        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string FuturoId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Vision { get; set; }
        

        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }
    }
}
