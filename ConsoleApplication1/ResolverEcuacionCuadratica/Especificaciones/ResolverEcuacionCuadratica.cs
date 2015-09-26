﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    class ResolverEcuacionCuadratica
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

                //calcular las raices
                CalcularRaices calcularRaices = new CalcularRaices();
                calcularRaices.CalcularLasRaices(Parametros);
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
