using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Horarios
    {
        public int idhorario {  get; set; }
        public Cargos oCargo { get; set; }
        public string horainicio { get; set; } // Cambiar a DateTime
        public string horasalida { get; set; }
    }
}
