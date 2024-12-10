using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CCargos
    {
        private MCargos obj_cargo = new MCargos();
        public List<Cargos> Listar()
        {
            return obj_cargo.Listar();
        }

        public List<Cargos> ListarCargos()
        {
            return obj_cargo.ListarCargos();
        }

        public int Registrar(Cargos obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombrecargo == "")
            {
                Mensaje += "Ingrese el cargo \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return obj_cargo.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Cargos obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombrecargo == "")
            {
                Mensaje += "Es necesario el nombre del cargo \n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_cargo.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Cargos obj, out string Mensaje)
        {
            return obj_cargo.Eliminar(obj, out Mensaje);
        }

    }
}
