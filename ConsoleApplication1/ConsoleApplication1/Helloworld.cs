using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResolverEcuacionCuadratica;



namespace ConsoleApplication
{
   public class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Escriba A");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba B");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba C");
            double c = Double.Parse(Console.ReadLine());
            clsParametrosEcuacion parametros = new clsParametrosEcuacion(a,b,c);

            ResolverEcuacionCuadratica.ResolverEcuacionCuadratica ecuacion = new ResolverEcuacionCuadratica.ResolverEcuacionCuadratica();
            ecuacion.ResolverLaEcuacionCuadratica(parametros);
            Console.WriteLine(parametros.getPrimerRaiz());
            Console.WriteLine(parametros.getSegundRaiz());

            Console.ReadKey();

            
        }
    }
}
