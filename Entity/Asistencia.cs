using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Asistencia
    {
        public int idasistencia { get; set; }
        public Empleados oEmpleados { get; set; }
        public string horaentrada { get; set; }
        public string horasalida { get; set; }
        public string horastrabajadas { get; set; }
        public string fecharegistro { get; set; }
    }
}
