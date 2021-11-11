using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {

        }

        private bool validaDados()
        {
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("O CPF está nulo!",
                    "Verifique o CPF", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCPF.Focus();
                return false;
            }

            DateTime dataAux;
            if(!(DateTime.TryParse(txtDataNasc.Text, out dataAux)))
            {
                MessageBox.Show("O CPF está nulo!",
                    "Verifique o CPF", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtDataNasc.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O Nome está nulo!",
                    "Verifique o Nome", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Clear();
            txtCPF.Clear();
            txtDataNasc.Clear();
            txtNome.Clear();
        }
    }
}
