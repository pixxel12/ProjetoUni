
namespace Projeto_com_Dois_Forms
{
    partial class FrmPessoas
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
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPessoas
            // 
            this.txtPessoas.Location = new System.Drawing.Point(2, 2);
            this.txtPessoas.Multiline = true;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(376, 294);
            this.txtPessoas.TabIndex = 0;
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(2, 303);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(376, 31);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FrmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 338);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.txtPessoas);
            this.Name = "FrmPessoas";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.FrmPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPessoas;
        private System.Windows.Forms.Button btFechar;
    }
}