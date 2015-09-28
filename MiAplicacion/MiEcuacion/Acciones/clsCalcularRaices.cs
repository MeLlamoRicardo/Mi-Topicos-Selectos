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
            if (p.a != 0) {
                p.primeraRaiz = (-(p.b) + Math.Sqrt(p.discriminante)) / (2 * p.a);
                p.segundaRaiz = (-(p.b) - Math.Sqrt(p.discriminante)) / (2 * p.a);
            }
            else
            {
                Exception ex = new Exception(string.Format("Error, el valor de a es cero "));
                throw ex;
            }
        }
    }
}
