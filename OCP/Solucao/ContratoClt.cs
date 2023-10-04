using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.Solucao
{
    public class ContratoClt : IRemuneravel
    {
        public decimal CalcularRemuneracao()
        {
            decimal valorHora = 80;
            int horasDiarias = 8;
            int diasTrabalhados = 24;
            return valorHora * horasDiarias * diasTrabalhados;
        }
    }
}
