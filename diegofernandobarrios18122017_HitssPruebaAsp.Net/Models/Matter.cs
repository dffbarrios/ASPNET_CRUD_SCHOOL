using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Models
{
    public class Matter
    {
        [Display(Name = "Id Materia")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El nombre supera el número de caracteres validos")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [Display(Name="Nombre Materia")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Grado Materia")]
        public GradeEnum Grade { get; set; }
        
        [Display(Name = "Docente Director")]
        public int IdTeacher { get; set; }

        //Virtual property for relation
        public virtual Teacher Director { get; set; } 

        public virtual ObservableCollection<MatterStudent>
            StudentsMatter { get; set; }
    }
}