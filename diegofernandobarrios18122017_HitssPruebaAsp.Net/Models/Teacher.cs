using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Models
{
    public class Teacher
    {
        [Display(Name="Id Docente")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo Documento")]
        public TeacherDocumentTypeEnum TypeDocument { get; set; }

        [Required]
        [Display(Name = "Documento N°")]
        [MaxLength(30, ErrorMessage = "El número de caracteres supera el permitido")]
        [RegularExpression("[0-9]+", ErrorMessage = "Ingresar solo números.")]
        public string IdDocument { get; set; }
        
        [Required]
        [Display(Name = "Nombres")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [MaxLength(30, ErrorMessage = "El número de caracteres supera el permitido")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "No ingresar caracteres especiales.")]
        [MaxLength(30, ErrorMessage = "El número de caracteres supera el permitido")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Pregrado")]
        [MaxLength(50, ErrorMessage = "El número de caracteres supera el permitido")]
        public string Profession { get; set; }

        [Required]
        [Display(Name = "Postgrado")]
        public PostgradeEnum Postgrade { get; set; }

        //Virtual property for relation
        public virtual ObservableCollection<Matter> 
            Matters { get; set; }
    }
}