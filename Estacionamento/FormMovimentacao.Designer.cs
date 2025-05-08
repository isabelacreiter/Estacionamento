namespace Estacionamento
{
    partial class FormMovimentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPlacaConsulta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblDataInicio = new Label();
            label3 = new Label();
            lblDataFim = new Label();
            lblDuracao = new Label();
            label5 = new Label();
            label4 = new Label();
            lblTempoCobrado = new Label();
            label6 = new Label();
            lblPreco = new Label();
            label7 = new Label();
            lblValorTotal = new Label();
            btnConsultarMovimentacao = new Button();
            btnRegistrarEntrada = new Button();
            btnRegistrarSaida = new Button();
            btnVoltarParaPreco = new Button();
            btnFinalizar = new Button();
            btnVoltarParaCadastroVeiculo = new Button();
            SuspendLayout();
            // 
            // txtPlacaConsulta
            // 
            txtPlacaConsulta.Location = new Point(196, 46);
            txtPlacaConsulta.Name = "txtPlacaConsulta";
            txtPlacaConsulta.Size = new Size(125, 27);
            txtPlacaConsulta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 49);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite a placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 143);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Data de Início:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Location = new Point(196, 143);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(0, 20);
            lblDataInicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 179);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Data de Fim:";
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Location = new Point(196, 179);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(0, 20);
            lblDataFim.TabIndex = 5;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Location = new Point(196, 215);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(0, 20);
            lblDuracao.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 215);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 7;
            label5.Text = "Duração:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 247);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 8;
            label4.Text = "Tempo Cobrado:";
            // 
            // lblTempoCobrado
            // 
            lblTempoCobrado.AutoSize = true;
            lblTempoCobrado.Location = new Point(196, 247);
            lblTempoCobrado.Name = "lblTempoCobrado";
            lblTempoCobrado.Size = new Size(0, 20);
            lblTempoCobrado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 284);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "Preço:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(196, 284);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(0, 20);
            lblPreco.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 320);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 12;
            label7.Text = "Valor Total:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(196, 320);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(0, 20);
            lblValorTotal.TabIndex = 13;
            // 
            // btnConsultarMovimentacao
            // 
            btnConsultarMovimentacao.Location = new Point(351, 95);
            btnConsultarMovimentacao.Name = "btnConsultarMovimentacao";
            btnConsultarMovimentacao.Size = new Size(94, 29);
            btnConsultarMovimentacao.TabIndex = 14;
            btnConsultarMovimentacao.Text = "Buscar";
            btnConsultarMovimentacao.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.Location = new Point(70, 95);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(146, 29);
            btnRegistrarEntrada.TabIndex = 15;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.Location = new Point(222, 95);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(123, 29);
            btnRegistrarSaida.TabIndex = 16;
            btnRegistrarSaida.Text = "Registrar Saída";
            btnRegistrarSaida.UseVisualStyleBackColor = true;
            btnRegistrarSaida.Click += btnRegistrarSaida_Click;
            // 
            // btnVoltarParaPreco
            // 
            btnVoltarParaPreco.Location = new Point(301, 363);
            btnVoltarParaPreco.Name = "btnVoltarParaPreco";
            btnVoltarParaPreco.Size = new Size(191, 29);
            btnVoltarParaPreco.TabIndex = 18;
            btnVoltarParaPreco.Text = "Voltar para Tabela Preço";
            btnVoltarParaPreco.UseVisualStyleBackColor = true;
            btnVoltarParaPreco.Click += btnVoltarParaPreco_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(498, 363);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 19;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnVoltarParaCadastroVeiculo
            // 
            btnVoltarParaCadastroVeiculo.Location = new Point(71, 363);
            btnVoltarParaCadastroVeiculo.Name = "btnVoltarParaCadastroVeiculo";
            btnVoltarParaCadastroVeiculo.Size = new Size(224, 29);
            btnVoltarParaCadastroVeiculo.TabIndex = 20;
            btnVoltarParaCadastroVeiculo.Text = "Voltar para Cadastro Veículo";
            btnVoltarParaCadastroVeiculo.UseVisualStyleBackColor = true;
            btnVoltarParaCadastroVeiculo.Click += btnVoltarParaCadastroVeiculo_Click;
            // 
            // FormMovimentacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarParaCadastroVeiculo);
            Controls.Add(btnFinalizar);
            Controls.Add(btnVoltarParaPreco);
            Controls.Add(btnRegistrarSaida);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(btnConsultarMovimentacao);
            Controls.Add(lblValorTotal);
            Controls.Add(label7);
            Controls.Add(lblPreco);
            Controls.Add(label6);
            Controls.Add(lblTempoCobrado);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblDuracao);
            Controls.Add(lblDataFim);
            Controls.Add(label3);
            Controls.Add(lblDataInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPlacaConsulta);
            Name = "FormMovimentacao";
            Text = "FormMovimentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlacaConsulta;
        private Label label1;
        private Label label2;
        private Label lblDataInicio;
        private Label label3;
        private Label lblDataFim;
        private Label lblDuracao;
        private Label label5;
        private Label label4;
        private Label lblTempoCobrado;
        private Label label6;
        private Label lblPreco;
        private Label label7;
        private Label lblValorTotal;
        private Button btnConsultarMovimentacao;
        private Button btnRegistrarEntrada;
        private Button btnRegistrarSaida;
        private Button btnVoltarParaPreco;
        private Button btnFinalizar;
        private Button btnVoltarParaCadastroVeiculo;
    }
}