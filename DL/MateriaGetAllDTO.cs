using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class MateriaGetAllDTO
    {
        public int IdMateria { get; set; }
        public string? NombreMateria { get; set; }
        public byte Creditos { get; set; }
        public decimal Costo { get; set; }
        public int IdSemestre { get; set; }
        public string? NombreSemestre { get; set; }
    }
}
