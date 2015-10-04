using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolver
{
     public class ValidarDiscriminante
    {
        public bool ValidarElDiscriminanteMayorQueCero (double discriminante)
        {
            bool resultado = false;
            resultado = (discriminante >= 0);
            return resultado;
        }
    


    }
}
