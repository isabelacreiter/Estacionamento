using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class cadastroVeiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }

        public bool CadastrarVeiculo()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBanco.bancoSrevidor))
                {
                    conexao.Open();
                    string insert = "INSERT INTO veiculo (nome, placa, ano) VALUES (@nome, @placa, @ano)";
                    MySqlCommand comando = new MySqlCommand(insert, conexao);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@placa", Placa);
                    comando.Parameters.AddWithValue("@ano", Ano);

                    comando.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar veículo: " + ex.ToString());
                return false;
            }
        }
    }
}