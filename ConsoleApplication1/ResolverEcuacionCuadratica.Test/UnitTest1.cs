using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolverEcuacionCuadratica;

namespace ResolverEcuacionCuadratica.Test
{
    /*
    Declare variables para los parámetros reales
    Declare variables para los resultados reales
    Declare variables para los resultados esperados
    Construya la lógicas que realiza la prueba
    Asegúrese de que los valores reales son iguales a los esperados.    
   */
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
            clsParametrosEcuacion parametros = new clsParametrosEcuacion(primer,segundo,tercer);

            ResolverEcuacionCuadratica resolver = new ResolverEcuacionCuadratica();
            //invoque al método correspondiente
            resolver.ResolverLaEcuacionCuadratica(parametros);

            Assert.IsTrue((primeraRaizEsperada == parametros.getPrimerRaiz() || 
                           primeraRaizEsperada == parametros.getSegundRaiz()));

            Assert.IsTrue((segundaRaizEsperada == parametros.getPrimerRaiz() || 
                           segundaRaizEsperada == parametros.getSegundRaiz()));

        }

        [TestMethod]
        public void ProbarCero()
        {
            double primer = 0;
            double segundo = 2;
            double tercer = 3;
            double primeraRaizEsperada = 3;
            double segundaRaizEsperada = -1;
            clsParametrosEcuacion parametros = new clsParametrosEcuacion(primer, segundo, tercer);

            ResolverEcuacionCuadratica resolver = new ResolverEcuacionCuadratica();
            //invoque al método correspondiente
            resolver.ResolverLaEcuacionCuadratica(parametros);

            Assert.IsTrue((primeraRaizEsperada == parametros.getPrimerRaiz() ||
                           primeraRaizEsperada == parametros.getSegundRaiz()));

            Assert.IsTrue((segundaRaizEsperada == parametros.getPrimerRaiz() ||
                           segundaRaizEsperada == parametros.getSegundRaiz()));

        }
    }
}
/* 
        tarea moral:
        cree pruebas unitarias para los siguientes casos:
        - Pruebas correctas para resultados reales con muchos decimales, 
          de modo que la coincidencia NO sea exacta y se apruebe 
          cuando hay coincidan al menos en el sexto decimal
        - pruebas correctas para cuando el discriminante es negativo
        - pruebas para cuando el valor de a (primerNumero) es igual a cero (0)
        */

