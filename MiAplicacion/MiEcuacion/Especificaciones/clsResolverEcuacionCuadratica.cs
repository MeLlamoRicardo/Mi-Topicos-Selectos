using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEcuacion
{
    public class clsResolverEcuacionCuadratica
    {
        public void ResolverEcuacionCuadratica(clsMisParametros p)
        {
            //Calcular el Discriminante.
            clsCalcularDiscriminante calcularDiscriminante = new clsCalcularDiscriminante();
            calcularDiscriminante.CalcularDiscriminante(p);

            //Validar el Discriminante.
            clsValidarDiscriminante validarDiscriminante = new clsValidarDiscriminante();
            if (validarDiscriminante.ValidarDiscriminante(p))
            {
                //Calcular las Raices
                clsCalcularRaices calcularRaices = new clsCalcularRaices();
                calcularRaices.CalcularRaices(p);
            }
            else
            {
                //Levanto una Excepción.
                Exception ex = new Exception(string.Format("Ocurrió un error al calcular las raices, ya que [{1}] es mayor que el discriminante [{0}].", p.discriminante, "0.0"));
                throw ex;
            }
        }
    }
}
