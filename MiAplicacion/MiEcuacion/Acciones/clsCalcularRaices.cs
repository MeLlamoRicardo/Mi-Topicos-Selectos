using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEcuacion
{
    public class clsCalcularRaices
    {
        public void CalcularRaices(clsMisParametros p)
        {
            p.primeraRaiz= (-(p.b) + Math.Sqrt(p.discriminante)) / (2 * p.a);
            p.segundaRaiz = (-(p.b) - Math.Sqrt(p.discriminante)) / (2 * p.a);
        }
    }
}
