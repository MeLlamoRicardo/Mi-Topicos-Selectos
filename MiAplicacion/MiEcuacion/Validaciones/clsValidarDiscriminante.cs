using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEcuacion
{
    public class clsValidarDiscriminante
    {
        public bool ValidarDiscriminante(clsMisParametros p)
        {
            bool resultado = false;
            resultado = (p.discriminante >= 0);
            return resultado;
        }
    }
}
