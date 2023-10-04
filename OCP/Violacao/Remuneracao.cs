using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.OCP.Violacao
{
    public class Remuneracao
    {
        public void Remunerar(Guid contratoId, TipoContrato tipoContrato)
        {
            if (tipoContrato == TipoContrato.Clt)
            {

                decimal valorHora = 80;
                int horasDiarias = 8;
                int diasTrabalhados = 24;

                decimal remuneracaoTotal = valorHora * horasDiarias * diasTrabalhados;

                Console.WriteLine($"Remuneração total para CLT: {remuneracaoTotal}");
            }

            else if (tipoContrato == TipoContrato.Estagio)
            {
                decimal valorHora = 20;
                int horasDiarias = 6;
                int diasTrabalhados = 24;

                decimal remuneracaoTotal = valorHora * horasDiarias * diasTrabalhados;

                Console.WriteLine($"Remuneração total para Estágio: {remuneracaoTotal}");

            }
        }
    }
}