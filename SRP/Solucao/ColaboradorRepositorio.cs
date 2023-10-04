using System.Data;
using System.Data.SqlClient;

namespace Solid.SRP.Solucao
{
    public class ColaboradorRepositorio
    {
        public void AdicionarColaborador( Colaborador colaborador)
        {
            using (var conexao = new SqlConnection())
            {
                var comando = new SqlCommand();

                conexao.ConnectionString = "MinhaConexaoString";
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO COLABORADOR (NOME, EMAIL, CNPJ, DATACADASTRO) VALUES(@nome, @email, @cnpj, @dataCad)";

                comando.Parameters.AddWithValue("nome", colaborador.Nome);
                comando.Parameters.AddWithValue("email", colaborador.Email);
                comando.Parameters.AddWithValue("cnpj", colaborador.Cpf);
                comando.Parameters.AddWithValue("dataCadastro", colaborador.DataCadastro);
                
                conexao.Open();
                comando.ExecuteNonQuery();

            }
        }
    }
}