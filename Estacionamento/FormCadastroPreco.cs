using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class FormCadastroPreco : Form
    {
        public FormCadastroPreco()
        {
            InitializeComponent();
        }

        private void btnCadastrarAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorInicial.Text) || string.IsNullOrEmpty(txtValorAdicional.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "Server=localhost;Port=3306;Database=dbEstacionamento;User=root;Password=1IsabelaCR2;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                INSERT INTO tabela_preco (data_inicio, data_fim, valor_inicial, valor_adicional, descricao, inicio_vigencia)
                VALUES (@data_inicio, @data_fim, @valor_inicial, @valor_adicional, @descricao, @inicio_vigencia)
                ON DUPLICATE KEY UPDATE 
                    valor_inicial = VALUES(valor_inicial), 
                    valor_adicional = VALUES(valor_adicional),
                    descricao = VALUES(descricao), 
                    inicio_vigencia = VALUES(inicio_vigencia),
                    fim_vigencia = VALUES(data_fim)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@data_inicio", dtInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@data_fim", dtFim.Value.Date);
                    cmd.Parameters.AddWithValue("@valor_inicial", Convert.ToDecimal(txtValorInicial.Text));
                    cmd.Parameters.AddWithValue("@valor_adicional", Convert.ToDecimal(txtValorAdicional.Text));
                    cmd.Parameters.AddWithValue("@descricao", "Descrição do preço");
                    cmd.Parameters.AddWithValue("@inicio_vigencia", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro ou atualização realizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIrParaMovimentacao_Click(object sender, EventArgs e)
        {
            FormMovimentacao movimentacaoForm = new FormMovimentacao();
            movimentacaoForm.Show();
            this.Hide();
        }

        private void btnVoltarParaCadastroVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastroVeiculo formVeiculo = new FormCadastroVeiculo();
            formVeiculo.Show();
            this.Hide();
        }
    }
}