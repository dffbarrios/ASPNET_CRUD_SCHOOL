using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Models
{
    public class Student
    {
        [Display(Name = "Id Estudiante")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Tipo Documento")]
        public StudentDocumentTypeEnum DocumentType { get; set; }

        [Required]
        [Display(Name="ID Estudiante")]
        [MaxLength(20, ErrorMessage = "El número de caracteres supera el permitido")]
        [RegularExpression("[0-9]+", ErrorMessage = "Ingresar solo números.")]
        public string IdDocument { get; set; }

        [Required]
        [Display(Name="Nombres")]
        [MaxLength(30, ErrorMessage = "El número de caracteres supera el permitido")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "No ingresar caracteres especiales.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [MaxLength(30, ErrorMessage = "El número de caracteres supera el permitido")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "No ingresar caracteres especiales.")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Genero")]
        public GenderEnum Gender { get; set; }
        
        //Relation
        public virtual ObservableCollection<MatterStudent>
               MattersStudent { get; set; }
    }
}