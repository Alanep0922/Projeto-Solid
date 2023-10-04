using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.SRP.Solucao
{
    public class ColaboradorService
    {
        private readonly ValidadorColaborador _validador;
        private readonly ColaboradorRepositorio _colaboradorRepositorio;
        private readonly EmailService _emailService;

        public ColaboradorService(ValidadorColaborador validador, ColaboradorRepositorio colaboradorRepositorio, EmailService emailService)
        {
            _validador = validador;
            _colaboradorRepositorio = colaboradorRepositorio;
            _emailService = emailService;
        }

        public void AdicionarColaborador(Colaborador colaborador)
        {
            _validador.Validar(colaborador);

            _colaboradorRepositorio.AdicionarColaborador(colaborador);

            _emailService.Enviar("colaborador@colaborador.com", colaborador.Email, "Bem Vindo", "Parabéns Você é o mais novo colaborador da Empresa");

            Console.WriteLine("Colaborador cadastrado com sucesso!");

        }
    }
}