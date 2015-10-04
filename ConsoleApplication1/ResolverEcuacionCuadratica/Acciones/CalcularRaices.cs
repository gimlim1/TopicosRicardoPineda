using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolver
{
    public class CalcularRaices
    {
        public void CalcularLasRaices(clsParametrosEcuacion parametros)
        {
            parametros.setPrimerRaiz((-parametros.getSegundo() + Math.Sqrt(parametros.getDiscriminante())) / (2 * parametros.getPrimer()));
            parametros.setSegundRaiz((-parametros.getSegundo() - Math.Sqrt(parametros.getDiscriminante())) / (2 * parametros.getPrimer()));
        }
    }
}
