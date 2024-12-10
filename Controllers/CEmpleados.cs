using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CEmpleados
    {
        private MEmpleados obj_empleado = new MEmpleados();
        public List<Empleados> Listar()
        {
            return obj_empleado.Listar();
        }

        public int Registrar(Empleados obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.documento == "")
            {
                Mensaje += "Es necesario el numero de documento \n";
            }
            if (obj.nombres == "")
            {
                Mensaje += "Ingrese su nombre";
            }
            if (obj.apellidos == "")
            {
                Mensaje += "Ingrese su apellidos";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_empleado.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Empleados obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el documento de identificacion del usuario\n";
            }
            if (obj.nombres == "")
            {
                Mensaje += "Ingrese su nombre";
            }
            if (obj.apellidos == "")
            {
                Mensaje += "Ingrese su apellidos";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_empleado.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Empleados obj, out string Mensaje)
        {
            return obj_empleado.Eliminar(obj, out Mensaje);
        }
    }
}
