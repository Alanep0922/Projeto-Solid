using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.Solucao
{
    public class Remuneracao
    {
        public void PagarRemuneracao(IRemuneravel contrato)
        {
            decimal remuneracao = contrato.CalcularRemuneracao();
            Console.WriteLine($"Remuneração total: {remuneracao}");
        }
    }
}