using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ResolverEcuacionCuadratica.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ResolverEcuacionCadratica : IResolverEcuacionCadratica
    {

        public void ResolverLaEcuacionCuadratica(clsParametrosEcuacion Parametros)
        {
            // Se instancia la clase
            ResolverEcuacionCadratica resolver = new ResolverEcuacionCadratica();
            //Se invoca al metodo que resuelve la ecuación
            resolver.ResolverLaEcuacionCuadratica(Parametros);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
