using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Solid.SRP.Violacao
{
    public class Colaborador
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Salvar()
        {

            if (Id is null)
            {
                throw new ArgumentNullException("id");
            }

            if (Cpf is null)
            {
                throw new ArgumentNullException("cpf");
            }

            if (Cpf.Length != 11)
            {
                throw new ArgumentOutOfRangeException("cpf", "cpf deve ter 11 caracteres");
            }

            if (Nome is null)
            {
                throw new ArgumentNullException("nome");
            }
            if (Email is null)
            {
                throw new ArgumentNullException("email");
            }

            using (var conexao = new SqlConnection())
            {
                var comando = new SqlCommand();

                conexao.ConnectionString = "MinhaConexaoString";
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO COLABORADOR (NOME, EMAIL, CNPJ, DATACADASTRO) VALUES(@nome, @email, @cnpj, @dataCad)";

                comando.Parameters.AddWithValue("nome", Nome);
                comando.Parameters.AddWithValue("email", Email);
                comando.Parameters.AddWithValue("cnpj", Cpf);
                comando.Parameters.AddWithValue("dataCadastro", DataCadastro);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            var email = new MailMessage("colaborador@colaborador.com", Email);
            var colaborador = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            email.Subject = "Bem vindo(a)!";
            email.Body = "Parabéns Você é o mais novo colaborador da Empresa";
            colaborador.Send(email);
        }
    }
}