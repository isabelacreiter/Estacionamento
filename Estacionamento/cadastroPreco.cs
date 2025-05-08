using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class cadastroPreco
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal ValorAdicional { get; set; }

        public bool CadastrarPreco()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConexaoBanco.bancoSrevidor);
                conexao.Open();

                string sql = "INSERT INTO tabela_preco (data_inicio, data_fim, valor_inicial, valor_adicional) VALUES (@inicio, @fim, @vinicial, @vadicional)";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@inicio", DataInicio);
                comando.Parameters.AddWithValue("@fim", DataFim);
                comando.Parameters.AddWithValue("@vinicial", ValorInicial);
                comando.Parameters.AddWithValue("@vadicional", ValorAdicional);

                comando.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar preço: " + ex.Message);
                return false;
            }
        }

        public MySqlDataReader ObterPrecoPorData(DateTime dataInicio)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConexaoBanco.bancoSrevidor);
                conexao.Open();

                string sql = "SELECT * FROM tabela_preco WHERE @dataInicio BETWEEN data_inicio AND data_fim";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@dataInicio", dataInicio);

                MySqlDataReader reader = comando.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar preço: " + ex.Message);
                return null;
            }
        }

    }
}
