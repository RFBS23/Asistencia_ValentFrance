using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CAsistencia
    {
        private MAsistencia obj_asistencia = new MAsistencia();
        public List<Asistencia> Listar(DateTime? fechaInicio = null, DateTime? fechaFin = null, int idEmpleado = 0)
        {
            return obj_asistencia.Listar(fechaInicio, fechaFin, idEmpleado);
        }

        public int Registrar(Asistencia obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.oEmpleados.documento == "")
            {
                Mensaje += "Ingrese su documento de identidad.";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_asistencia.Registrar(obj, out Mensaje);
            }
        }
    }
}
