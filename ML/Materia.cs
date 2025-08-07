using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }

        [Required(ErrorMessage = "Este campo es requerido" )]
        [MaxLength(50, ErrorMessage ="La longitud maxima es 50")]
        [MinLength(3)]
        [RegularExpression("sadasd", ErrorMessage = "Solo se aceptan letras")]
        public string? Nombre { get; set; }
        public byte Creditos { get; set; }
        [Range(10, 500)]
        public decimal Costo { get; set; }
        public ML.Semestre? Semestre { get; set; }
        public List<object>? Materias { get; set; }
    }
}
