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
     partial class FrmPessoas : Form
    {
        public List<Pessoa> ListaPessoas { get; set; }


        public FrmPessoas()
        {
            InitializeComponent();

            foreach (Pessoa p in ListaPessoas)
            {
                txtPessoas.Text += p.listaDados();
                txtPessoas.Text += "=============";
            }

        }
        public FrmPessoas(List<Pessoa> pessoas)
        {
            InitializeComponent();
            this.ListaPessoas = pessoas;

        }


        private void btFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmPessoas_Load(object sender, EventArgs e)
        {

        }
    }
}
