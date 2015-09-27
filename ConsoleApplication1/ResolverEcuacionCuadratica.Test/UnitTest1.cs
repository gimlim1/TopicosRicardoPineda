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

            clsParametrosEcuacion parametros = new clsParametrosEcuacion(primer, segundo, tercer);

            Assert.IsTrue(parametros.getPrimer() == 0);
         
       } 

        [TestMethod]
        public void ProbarDiscriminante()
        {
            double primer = 3;
            double segundo = 2;
            double tercer = 1;

            clsParametrosEcuacion parametros = new clsParametrosEcuacion(primer, segundo, tercer);
            CalcularDiscriminante discri = new CalcularDiscriminante();

            discri.CalcularElDiscriminante(parametros);

            ValidarDiscriminante validar = new ValidarDiscriminante();
            //invoque al método correspondiente
            Assert.IsFalse(validar.ValidarElDiscriminanteMayorQueCero(parametros.getDiscriminante()));
          
        }
}

}
     /* 
        tarea moral:
        cree pruebas unitarias para los siguientes casos:
        - pruebas correctas para cuando el discriminante es negativo
        - pruebas para cuando el valor de a (primerNumero) es igual a cero (0)
      */

