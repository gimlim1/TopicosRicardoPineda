using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class clsParametrosEcuacion
    {

        private double primerNumero;
        private double segundoNumero;
        private double tercerNumero;
        private double primeraiz;
        private double segundraiz;
        private double discriminante;
        
        public clsParametrosEcuacion(double primer,double segundo,double tercer)
        {
            this.primerNumero = primer;
            this.segundoNumero = segundo;
            this.tercerNumero = tercer;
        }

        public double getPrimer() {
            return primerNumero;
        }
        public double getSegundo()
        {
            return segundoNumero;
        }

        public double getTercer()
        {
            return tercerNumero;
        }
        public double getPrimerRaiz()
        {
            return primeraiz;
        }
        public double getSegundRaiz()
        {
            return segundraiz;
        }
        public double getDiscriminante()
        {
            return discriminante;
        }

        public void setPrimer(double primer)
        {
            this.primerNumero = primer;
        }
        public void setSegundo(double segundo)
        {
            this.segundoNumero = segundo;
        }
        public void setTercer(double Tercero)
        {
            this.tercerNumero = Tercero;
        }
        public void setPrimerRaiz(double primeraraiz)
        {
            this.primeraiz = primeraraiz;
        }
        public void setSegundRaiz(double segundaraiz)
        {
            this.segundraiz = segundaraiz;
        }
        public void setDiscriminante(double discri)
        {
            this.discriminante = discri;
        }
    }
}
