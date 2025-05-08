using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class FormCadastroVeiculo : Form
    {
        public FormCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void FormCadastroVeiculo_Load(object sender, EventArgs e)
        {
            // Se necessário, adicione inicializações aqui
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            string nomeVeiculo = txtNomeVeiculo.Text.Trim();
            string placa = txtPlaca.Text.Trim();
            string anoTexto = txtAno.Text.Trim();

            if (string.IsNullOrEmpty(nomeVeiculo) || string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(anoTexto))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            if (!int.TryParse(anoTexto, out int ano))
            {
                MessageBox.Show("Ano inválido. Digite apenas números.");
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;database=dbEstacionamento;user=root;password=1IsabelaCR2;"))
                {
                    conexao.Open();

                    string sql = @"INSERT INTO veiculo (nome, placa, ano)
                                   VALUES (@nome, @placa, @ano)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeVeiculo);
                        cmd.Parameters.AddWithValue("@placa", placa);
                        cmd.Parameters.AddWithValue("@ano", ano);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Veículo cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o veículo: " + ex.ToString());
            }
        }

        private void btnCadastrarPreco_Click_1(object sender, EventArgs e)
        {
            FormCadastroPreco formPreco = new FormCadastroPreco();
            formPreco.Show();
            this.Hide(); 
        }

        private void btnMovimentacao_Click_1(object sender, EventArgs e)
        {
            FormMovimentacao formMovimentacao = new FormMovimentacao();
            formMovimentacao.Show();
            this.Hide(); 
        }
    }
}
