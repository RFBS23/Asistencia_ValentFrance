using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CNivelAcceso
    {
        private DNivelAcceso obj_nivelacceso = new DNivelAcceso();
        public List<NivelAcceso> listar()
        {
            return obj_nivelacceso.Listar();
        }
    }
}
