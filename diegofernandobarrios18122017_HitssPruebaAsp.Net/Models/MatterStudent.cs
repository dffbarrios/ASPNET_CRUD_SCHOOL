using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Models
{
    public class MatterStudent
    {
        [Required]
        [Key, Column(Order = 0)]
        [RegularExpression("[0-9]+", ErrorMessage = "Ingresar solo números.")]
        [Display(Name ="ID Materia")]
        public int IdMatter { get; set; }

        [Required]
        [Key, Column(Order = 1)]
        [RegularExpression("[0-9]+", ErrorMessage = "Ingresar solo números.")]
        [Display(Name = "ID Estudiante")]
        public int IdStudent { get; set; }

        [Display(Name = "Nota Periodo 1")]
        public float? NoteOne { get; set; } = 0;

        [Display(Name = "Nota Periodo 2")]
        public float? NoteTwo { get; set; } = 0;

        //Virtual
        public virtual Student Students { get; set; }
        public virtual Matter Matters { get; set; }        
    }
}