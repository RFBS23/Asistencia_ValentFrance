using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleados
    {
        public int idempleado {  get; set; }
        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public Cargos oCargo { get; set; }
        public Horarios oHorario { get; set; }
    }
}
