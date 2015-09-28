using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEcuacion
{
    public class clsCalcularDiscriminante
    {
        public void  CalcularDiscriminante(clsMisParametros p)
        {
            p.discriminante = (Math.Pow(p.b, 2) - 4 * p.a * p.c);
        }
    }
}
