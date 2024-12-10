using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CHorarios
    {
        private MHorarios obj_horario = new MHorarios();
        public List<Horarios> Listar()
        {
            return obj_horario.Listar();
        }

        public int Registrar(Horarios obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.horainicio))
            {
                Mensaje += "Es necesario que ingrese la hora de inicio \n";
            }
            if (string.IsNullOrWhiteSpace(obj.horasalida))
            {
                Mensaje += "Es necesario que ingrese la hora de salida \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_horario.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Horarios obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.horainicio == "")
            {
                Mensaje += "Es necesario cambiar la hora de entrada \n";
            }
            if (obj.horasalida == "")
            {
                Mensaje += "Es necesario cambaria la hora de salida \n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_horario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Horarios obj, out string Mensaje)
        {
            return obj_horario.Eliminar(obj, out Mensaje);
        }

        public List<Horarios> FiltrosHorarios(int idcargo)
        {
            return obj_horario.FiltrosHorarios(idcargo);
        }

    }
}
