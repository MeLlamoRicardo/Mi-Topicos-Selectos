using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiEcuacion;

/* 
tarea moral:
cree pruebas unitarias para los siguientes casos:
- Pruebas correctas para resultados reales con muchos decimales, de modo que la coincidencia NO sea exacta y se apruebe cuando coincidan al menos en el sexto decimal.
- Pruebas correctas para cuando el discriminante es negativo.
- Pruebas para cuando el valor de a (primerNumero) es igual a cero (0).
*/

namespace MiTest
{
    [TestClass]
    public class clsPruebasEcuacion
    {
        //(1)  Declarar variables para los parametros reales 
        //(2)  Declarar variables requeridos para los valores reales
        //(3)  Declarar variables requeridos para los valores esperados
        clsMisParametros p = new clsMisParametros();
        clsValidarDiscriminante validacion = new clsValidarDiscriminante();
        clsCalcularDiscriminante discriminante = new clsCalcularDiscriminante();
        clsResolverEcuacionCuadratica ecuacion = new clsResolverEcuacionCuadratica();
        double primeraRaizEsperada, segundaRaizEsperada;
        bool aux;


        [TestMethod]
        public void ProbarExactos()
        {
            //Variables para los parametros reales.
            p.a = -1;
            p.b = 2;
            p.c = 3;

            //Variables requeridas para los valores reales.
            p.primeraRaiz = 0;
            p.segundaRaiz = 0;

            //Variables requeridas para los valores esperados.
            primeraRaizEsperada = -1;
            segundaRaizEsperada = 3;

            //Construir lógica que realiza la prueba.
            ecuacion.ResolverEcuacionCuadratica(p);

            //Validar que los valores reales son iguales a los esperados 

            Assert.IsTrue((primeraRaizEsperada == p.primeraRaiz) || (primeraRaizEsperada == p.segundaRaiz));
            Assert.IsTrue((segundaRaizEsperada == p.primeraRaiz) || (segundaRaizEsperada == p.segundaRaiz));

        }

        [TestMethod]
        public void ProbarDiscrimnateCorrecto()
        {
            //Variables para los parametros reales.
            p.a = 3;
            p.b = 2;
            p.c = 1;

            //Variables requeridas para los valores reales.
            //Variables requeridas para los valores esperados.

            //Construir logica que realiza la prueba. 
            discriminante.CalcularDiscriminante(p);
            aux = validacion.ValidarDiscriminante(p);

            //Validar que los valores reales son iguales a los esperados. 
            Assert.IsTrue(false == aux);
        }

        [TestMethod]
        public void DiscrimnateDiferenteCero()
        {
            //Variables para los parametros reales.
            p.a = 3;
            p.b = 2;
            p.c = 1;

            //Variables requeridas para los valores reales.
            //Variables requeridas para los valores esperados.

            //Construir logica que realiza la prueba. 
            discriminante.CalcularDiscriminante(p);
            aux = validacion.ValidarDiscriminante(p);

            //Validar que los valores reales son iguales a los esperados. 
            Assert.IsTrue(p.a != 0);
        }
    }
}
