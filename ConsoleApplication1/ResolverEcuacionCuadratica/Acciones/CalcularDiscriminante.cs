using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularDiscriminante
    {
        public clsParametrosEcuacion CalcularElDiscriminante(clsParametrosEcuacion parametros)
        {
            parametros.setDiscriminante((Math.Pow(parametros.getSegundo(), 2) - 4 * parametros.getPrimer() * parametros.getTercer()));
            return (parametros);
        }
    }
}
