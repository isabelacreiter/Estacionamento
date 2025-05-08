namespace Estacionamento
{
    partial class FormCadastroPreco
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
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtValorInicial = new TextBox();
            txtValorAdicional = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCadastrarAtualizar = new Button();
            btnIrParaMovimentacao = new Button();
            btnVoltarParaCadastroVeiculo = new Button();
            SuspendLayout();
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(254, 48);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(250, 27);
            dtInicio.TabIndex = 0;
            // 
            // dtFim
            // 
            dtFim.Location = new Point(254, 94);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(250, 27);
            dtFim.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label1.Location = new Point(105, 48);
            label1.Name = "label1";
            label1.Size = new Size(96, 24);
            label1.TabIndex = 2;
            label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(105, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 3;
            label2.Text = "Data Fim:";
            // 
            // txtValorInicial
            // 
            txtValorInicial.Location = new Point(254, 136);
            txtValorInicial.Name = "txtValorInicial";
            txtValorInicial.Size = new Size(250, 27);
            txtValorInicial.TabIndex = 4;
            // 
            // txtValorAdicional
            // 
            txtValorAdicional.Location = new Point(254, 182);
            txtValorAdicional.Name = "txtValorAdicional";
            txtValorAdicional.Size = new Size(250, 27);
            txtValorAdicional.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.Location = new Point(105, 136);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 6;
            label3.Text = "Valor Inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label4.Location = new Point(105, 182);
            label4.Name = "label4";
            label4.Size = new Size(131, 24);
            label4.TabIndex = 7;
            label4.Text = "Valor Adicional:";
            // 
            // btnCadastrarAtualizar
            // 
            btnCadastrarAtualizar.Location = new Point(105, 228);
            btnCadastrarAtualizar.Name = "btnCadastrarAtualizar";
            btnCadastrarAtualizar.Size = new Size(165, 29);
            btnCadastrarAtualizar.TabIndex = 10;
            btnCadastrarAtualizar.Text = "Cadastrar/Atualizar";
            btnCadastrarAtualizar.UseVisualStyleBackColor = true;
            btnCadastrarAtualizar.Click += btnCadastrarAtualizar_Click;
            // 
            // btnIrParaMovimentacao
            // 
            btnIrParaMovimentacao.Location = new Point(303, 228);
            btnIrParaMovimentacao.Name = "btnIrParaMovimentacao";
            btnIrParaMovimentacao.Size = new Size(201, 29);
            btnIrParaMovimentacao.TabIndex = 11;
            btnIrParaMovimentacao.Text = "Ir para a movimentação";
            btnIrParaMovimentacao.UseVisualStyleBackColor = true;
            btnIrParaMovimentacao.Click += btnIrParaMovimentacao_Click;
            // 
            // btnVoltarParaCadastroVeiculo
            // 
            btnVoltarParaCadastroVeiculo.Location = new Point(149, 272);
            btnVoltarParaCadastroVeiculo.Name = "btnVoltarParaCadastroVeiculo";
            btnVoltarParaCadastroVeiculo.Size = new Size(279, 29);
            btnVoltarParaCadastroVeiculo.TabIndex = 12;
            btnVoltarParaCadastroVeiculo.Text = "Voltar para cadastro Veículo";
            btnVoltarParaCadastroVeiculo.UseVisualStyleBackColor = true;
            btnVoltarParaCadastroVeiculo.Click += btnVoltarParaCadastroVeiculo_Click;
            // 
            // FormCadastroPreco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 323);
            Controls.Add(btnVoltarParaCadastroVeiculo);
            Controls.Add(btnIrParaMovimentacao);
            Controls.Add(btnCadastrarAtualizar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValorAdicional);
            Controls.Add(txtValorInicial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtFim);
            Controls.Add(dtInicio);
            Name = "FormCadastroPreco";
            Text = "FormCadastroPreco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtInicio;
        private DateTimePicker dtFim;
        private Label label1;
        private Label label2;
        private TextBox txtValorInicial;
        private TextBox txtValorAdicional;
        private Label label3;
        private Label label4;
        private Button btnCadastrarAtualizar;
        private Button btnIrParaMovimentacao;
        private Button btnVoltarParaCadastroVeiculo;
    }
}
