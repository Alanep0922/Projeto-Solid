using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.SRP.Solucao
{
    public class ValidadorColaborador
    {
        public void Validar(Colaborador colaborador)
        {
            if(colaborador == null)
            {
                throw new ArgumentNullException("colaborador");
            }

            if(colaborador.Id == null)
            {
                throw new ArgumentNullException("id");
            }

            if (colaborador.Cpf == null)
            {
                throw new ArgumentNullException("cpf");
            }

            if(colaborador.Cpf.Length != 11)
            {
                throw new ArgumentOutOfRangeException("cpf", "cpf deve ter 11 caracteres");
            }

            if(colaborador.Nome == null)
            {
                throw new ArgumentNullException("nome");
            }
            if (colaborador.Email == null)
            {
                throw new ArgumentNullException("email");
            }
        }
        
    }
}