
namespace CarRental
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.lbCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btProcurar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodigoCliente
            // 
            this.lbCodigoCliente.AutoSize = true;
            this.lbCodigoCliente.Location = new System.Drawing.Point(12, 9);
            this.lbCodigoCliente.Name = "lbCodigoCliente";
            this.lbCodigoCliente.Size = new System.Drawing.Size(93, 13);
            this.lbCodigoCliente.TabIndex = 0;
            this.lbCodigoCliente.Text = "Código do Cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(12, 25);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(104, 20);
            this.txtCodCliente.TabIndex = 1;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(217, 9);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(26, 13);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "Cpf:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(190, 25);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(111, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(380, 9);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbDataNascimento.TabIndex = 4;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(376, 25);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(111, 20);
            this.txtDataNasc.TabIndex = 5;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(12, 68);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(88, 13);
            this.lbNomeCliente.TabIndex = 6;
            this.lbNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(475, 20);
            this.txtNome.TabIndex = 7;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(15, 122);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(71, 28);
            this.btGravar.TabIndex = 8;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btFechar.Location = new System.Drawing.Point(412, 122);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 29);
            this.btFechar.TabIndex = 9;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(104, 122);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(69, 28);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btProcurar
            // 
            this.btProcurar.Location = new System.Drawing.Point(190, 122);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(75, 28);
            this.btProcurar.TabIndex = 11;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(15, 181);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(104, 22);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar Campos";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 215);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lbCodigoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Button btLimpar;
    }
}