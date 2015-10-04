using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Resolver;


namespace WcfResolverEcuacionCuadratica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ResolverEcuacion : IResolverEcuacion
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void Resolver(double primer, double segundo, double tercer,ref double raiz1,ref double raiz2)
        {
            clsParametrosEcuacion Parametros = new clsParametrosEcuacion(primer, segundo, tercer);
            ResolverEcuacionCuadratica resolver = new ResolverEcuacionCuadratica();
            resolver.ResolverLaEcuacionCuadratica(Parametros);
            raiz1 = Parametros.getPrimerRaiz();
            raiz2 = Parametros.getSegundRaiz();
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
