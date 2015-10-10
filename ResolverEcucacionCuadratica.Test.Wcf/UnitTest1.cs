using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ResolverEcucacionCuadratica.Test.Wcf
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProbarResolverCorrectoExacto()
        {
            double primer = -1;
            double segundo = 2;
            double tercer = 3;
            double primeraRaizEsperada = 3;
            double segundaRaizEsperada = -1;
            double real = 0;
            double real1 = 0;
            //clsParametrosEcuacion parametros = new clsParametrosEcuacion(primer, segundo, tercer);

            SICuadratica.ResolverEcuacionEcuadraticaClient resolver = new SICuadratica.ResolverEcuacionEcuadraticaClient();
            //invoque al método correspondiente
            resolver.ResolverEcuacion(primer, segundo, tercer, ref real, ref real1);
           //resolver.ResolverLaEcuacionCuadratica(parametros);
            Assert.IsTrue((primeraRaizEsperada == real ||
                           primeraRaizEsperada == real1));

            Assert.IsTrue((segundaRaizEsperada == real ||
                           segundaRaizEsperada == real1));
           
        }
    }
}
