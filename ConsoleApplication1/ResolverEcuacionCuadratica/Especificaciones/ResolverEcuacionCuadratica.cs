using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class ResolverEcuacionCuadratica
    {

        public void ResolverLaEcuacionCuadratica(clsParametrosEcuacion Parametros)
        {
            //calcular el discriminante
            CalcularDiscriminante accCalcularDiscriminante = new CalcularDiscriminante();
            accCalcularDiscriminante.CalcularElDiscriminante(Parametros);
            //validar el discriminante
            ValidarDiscriminante validarDiscriminante = new ValidarDiscriminante();
            if (validarDiscriminante.ValidarElDiscriminanteMayorQueCero(Parametros.getDiscriminante()))
            {
                ValidarPrimerNumero validarprimernumero = new ValidarPrimerNumero();
                if(validarprimernumero.ValidarPrimeroDiferenteDeCero(Parametros.getPrimer())){
                   //calcular las raices   
                   CalcularRaices calcularRaices = new CalcularRaices();
                   calcularRaices.CalcularLasRaices(Parametros);
                }
                else
                {
                    Exception ex = new Exception(string.Format("Ocurrió un error al calcular las raices," +
                            " ya que el primer numero [{0}] es cero", Parametros.getPrimer().ToString()));
                    throw ex;
                }
            }
            else
            //levante una excepción
            {
                Exception ex = new Exception(string.Format("Ocurrió un error al calcular las raices," + 
                            " ya que el discriminante [{0}] es menor que cero", Parametros.getDiscriminante().ToString()));
                throw ex;
            }
        }
    }
}
