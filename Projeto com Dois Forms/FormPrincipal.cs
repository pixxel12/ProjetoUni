using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_com_Dois_Forms
{
    public partial class FormPrincipal : Form
    {
        private List<Pessoa> pessoas;
        public FormPrincipal()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            textNome.Focus();

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textSobrenome.Text == "")
            {
                MessageBox.Show("Verifique se voce preencheu o nome e o sobrenome");
                    return;
            }

            Pessoa p = new Pessoa(
                textNome.Text,
                textSobrenome.Text,
                textMail.Text);

            pessoas.Add(p);

            textNome.Clear();
            textSobrenome.Clear();
            textMail.Clear();
            textNome.Focus();

            MessageBox.Show(p.Nome + "cadastrado(a)");

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
