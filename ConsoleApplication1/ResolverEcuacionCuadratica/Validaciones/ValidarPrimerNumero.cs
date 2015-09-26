using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
   public class ValidarPrimerNumero
    {
        public bool ValidarPrimeroDiferenteDeCero(double a)
        {
            bool resultado = false;
            resultado = (a != 0);
            return resultado;
        }
    }
}
