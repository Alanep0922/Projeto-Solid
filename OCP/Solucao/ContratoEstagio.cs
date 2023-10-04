using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.Solucao
{
    public class ContratoEstagio : IRemuneravel
    {
        public decimal CalcularRemuneracao()
        {
            decimal valorHora = 20;
            int horasDiarias = 6;
            int diasTrabalhados = 24;
            return valorHora * horasDiarias * diasTrabalhados;
        }
    }
}