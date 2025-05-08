namespace Estacionamento
{
    partial class FormCadastroVeiculo
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
            btnCadastrarVeiculo = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtAno = new TextBox();
            txtPlaca = new TextBox();
            txtNomeVeiculo = new TextBox();
            btnCadastrarPreco = new Button();
            btnMovimentacao = new Button();
            SuspendLayout();
            // 
            // btnCadastrarVeiculo
            // 
            btnCadastrarVeiculo.Location = new Point(38, 171);
            btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            btnCadastrarVeiculo.Size = new Size(157, 29);
            btnCadastrarVeiculo.TabIndex = 0;
            btnCadastrarVeiculo.Text = "Cadastrar Veículo";
            btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            btnCadastrarVeiculo.Click += btnCadastrarVeiculo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.Location = new Point(70, 93);
            label8.Name = "label8";
            label8.Size = new Size(68, 24);
            label8.TabIndex = 23;
            label8.Text = "Placa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(70, 129);
            label7.Name = "label7";
            label7.Size = new Size(159, 24);
            label7.TabIndex = 22;
            label7.Text = "Ano do Veículo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(70, 60);
            label6.Name = "label6";
            label6.Size = new Size(145, 24);
            label6.TabIndex = 21;
            label6.Text = "Nome Veiculo:";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(235, 126);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(197, 27);
            txtAno.TabIndex = 20;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(235, 93);
            txtPlaca.MaxLength = 10;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(197, 27);
            txtPlaca.TabIndex = 19;
            // 
            // txtNomeVeiculo
            // 
            txtNomeVeiculo.Location = new Point(235, 57);
            txtNomeVeiculo.MaxLength = 100;
            txtNomeVeiculo.Name = "txtNomeVeiculo";
            txtNomeVeiculo.Size = new Size(197, 27);
            txtNomeVeiculo.TabIndex = 18;
            // 
            // btnCadastrarPreco
            // 
            btnCadastrarPreco.Location = new Point(201, 171);
            btnCadastrarPreco.Name = "btnCadastrarPreco";
            btnCadastrarPreco.Size = new Size(129, 29);
            btnCadastrarPreco.TabIndex = 24;
            btnCadastrarPreco.Text = "Cadastrar Preço";
            btnCadastrarPreco.UseVisualStyleBackColor = true;
            btnCadastrarPreco.Click += btnCadastrarPreco_Click_1;
            // 
            // btnMovimentacao
            // 
            btnMovimentacao.Location = new Point(336, 171);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(125, 29);
            btnMovimentacao.TabIndex = 25;
            btnMovimentacao.Text = "Movimentação";
            btnMovimentacao.UseVisualStyleBackColor = true;
            btnMovimentacao.Click += btnMovimentacao_Click_1;
            // 
            // FormCadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 244);
            Controls.Add(btnMovimentacao);
            Controls.Add(btnCadastrarPreco);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtAno);
            Controls.Add(txtPlaca);
            Controls.Add(txtNomeVeiculo);
            Controls.Add(btnCadastrarVeiculo);
            Name = "FormCadastroVeiculo";
            Text = "FormCadastroVeiculo";
            Load += FormCadastroVeiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarVeiculo;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtAno;
        private TextBox txtPlaca;
        private TextBox txtNomeVeiculo;
        private Button btnCadastrarPreco;
        private Button btnMovimentacao;
    }
}