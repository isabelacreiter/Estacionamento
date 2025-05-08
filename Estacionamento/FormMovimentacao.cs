using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Estacionamento
{
    public partial class FormMovimentacao : Form
    {
        public FormMovimentacao()
        {
            InitializeComponent();
            btnConsultarMovimentacao.Click += btnConsultarMovimentacao_Click;
        }

        private void btnConsultarMovimentacao_Click(object sender, EventArgs e)
        {
            string placa = txtPlacaConsulta.Text.Trim();

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Por favor, insira a placa do veículo.");
                return;
            }

            string conexaoString = "server=localhost;port=3306;database=dbEstacionamento;user=root;password=1IsabelaCR2;";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();

                    string sql = @"SELECT placa, entrada, saida, tempo, valor
                                   FROM movimentacao
                                   WHERE placa = @placa";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@placa", placa);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblDataInicio.Text = Convert.ToDateTime(reader["entrada"]).ToString("dd/MM/yyyy HH:mm");
                                lblDataFim.Text = Convert.ToDateTime(reader["saida"]).ToString("dd/MM/yyyy HH:mm");
                                lblDuracao.Text = $"{reader["tempo"]} hora(s)";
                                lblTempoCobrado.Text = $"{reader["tempo"]} hora(s)";
                                lblPreco.Text = $"R$ {Convert.ToDecimal(reader["valor"]):N2}";
                                lblValorTotal.Text = $"R$ {Convert.ToDecimal(reader["valor"]):N2}";
                            }
                            else
                            {
                                MessageBox.Show("Veículo não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar movimentação: " + ex.Message);
            }
        }

        private void FormMovimentacao_Load(object sender, EventArgs e)
        {
            lblDataInicio.Text = "";
            lblDataFim.Text = "";
            lblDuracao.Text = "";
            lblTempoCobrado.Text = "";
            lblPreco.Text = "";
            lblValorTotal.Text = "";
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            string placa = txtPlacaConsulta.Text.Trim();

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Digite a placa do veículo.");
                return;
            }

            DateTime entrada = DateTime.Now;
            DateTime saida = DateTime.Now;

            using (var conexao = new MySqlConnection("server=localhost;port=3306;database=dbEstacionamento;user=root;password=1IsabelaCR2;"))
            {
                conexao.Open();

                string checkEntrada = @"SELECT COUNT(*) FROM movimentacao WHERE placa = @placa AND saida IS NULL";
                using (var cmd = new MySqlCommand(checkEntrada, conexao))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Já existe uma entrada registrada para essa placa sem saída.");
                        return;
                    }
                }

                string sql = "INSERT INTO movimentacao (placa, entrada) VALUES (@placa, @entrada)";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@entrada", entrada);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Entrada registrada com sucesso!");
        }

        private void btnRegistrarSaida_Click(object sender, EventArgs e)
        {
            string placa = txtPlacaConsulta.Text.Trim();
            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Por favor, insira a placa.");
                return;
            }

            DateTime dataSaida = DateTime.Now;
            string conexaoString = "server=localhost;port=3306;database=dbEstacionamento;user=root;password=1IsabelaCR2;";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();

                    string sqlSelect = "SELECT entrada FROM movimentacao WHERE placa = @placa AND saida IS NULL";
                    DateTime dataEntrada;

                    using (MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conexao))
                    {
                        cmdSelect.Parameters.AddWithValue("@placa", placa);
                        object result = cmdSelect.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Nenhuma entrada encontrada para esta placa.");
                            return;
                        }

                        dataEntrada = Convert.ToDateTime(result);
                    }

                    string sqlPreco = @"
                SELECT valor_inicial, valor_adicional 
                FROM tabela_preco 
                WHERE @dataEntrada BETWEEN data_inicio AND IFNULL(data_fim, @dataEntrada)
                ORDER BY inicio_vigencia DESC
                LIMIT 1";

                    decimal valorInicial = 0, valorAdicional = 0;

                    using (MySqlCommand cmdPreco = new MySqlCommand(sqlPreco, conexao))
                    {
                        cmdPreco.Parameters.AddWithValue("@dataEntrada", dataEntrada.Date);

                        using (MySqlDataReader readerPreco = cmdPreco.ExecuteReader())
                        {
                            if (readerPreco.Read())
                            {
                                valorInicial = Convert.ToDecimal(readerPreco["valor_inicial"]);
                                valorAdicional = Convert.ToDecimal(readerPreco["valor_adicional"]);
                            }
                            else
                            {
                                MessageBox.Show("Tabela de preços não encontrada para a data de entrada.");
                                return;
                            }
                        }
                    }

                    TimeSpan duracao = dataSaida - dataEntrada;
                    double minutosTotais = duracao.TotalMinutes;
                    int horasCobradas = 0;
                    decimal valorCobrado = 0;

                    if (minutosTotais <= 30)
                    {
                        valorCobrado = valorInicial / 2;
                        horasCobradas = 0;
                    }
                    else
                    {
                        horasCobradas = (int)(minutosTotais / 60);
                        double minutosExcedentes = minutosTotais % 60;

                        if (minutosExcedentes > 10)
                            horasCobradas++;

                        valorCobrado = valorInicial + (horasCobradas * valorAdicional);
                    }

                    string sqlUpdate = "UPDATE movimentacao SET saida = @saida, tempo = @tempo, valor = @valor WHERE placa = @placa AND saida IS NULL";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conexao))
                    {
                        cmdUpdate.Parameters.AddWithValue("@saida", dataSaida);
                        cmdUpdate.Parameters.AddWithValue("@tempo", horasCobradas);
                        cmdUpdate.Parameters.AddWithValue("@valor", valorCobrado);
                        cmdUpdate.Parameters.AddWithValue("@placa", placa);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    lblDataInicio.Text = dataEntrada.ToString("dd/MM/yyyy HH:mm");
                    lblDataFim.Text = dataSaida.ToString("dd/MM/yyyy HH:mm");
                    lblDuracao.Text = duracao.ToString(@"hh\:mm");
                    lblTempoCobrado.Text = $"{horasCobradas} hora(s)";
                    lblPreco.Text = $"R$ {valorInicial:N2}";
                    lblValorTotal.Text = $"R$ {valorCobrado:N2}";

                    MessageBox.Show("Saída registrada com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar saída: " + ex.Message);
            }
        }

        private void btnVoltarParaPreco_Click(object sender, EventArgs e)
        {
            FormCadastroPreco formPreco = new FormCadastroPreco();
            formPreco.Show();
            this.Hide();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltarParaCadastroVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastroVeiculo formVeiculo = new FormCadastroVeiculo();
            formVeiculo.Show();
            this.Hide();
        }
    }
}
