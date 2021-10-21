using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepadinho
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTexto f = new FrmTexto();
            f.Text = String.Format("Anotações - {0}", this.MdiChildren.Length + 1);
            f.MdiParent = this;
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            novoToolStripMenuItem_Click(sender, e);
            this.MdiChildren[0].WindowState = FormWindowState.Maximized;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAtivo = this.ActiveMdiChild;
            if(frmAtivo != null)
            {
                try
                {
                    RichTextBox txtUsuario = (RichTextBox)frmAtivo.ActiveControl;
                    if(txtUsuario != null)
                    {
                        SaveFileDialog save = new SaveFileDialog();
                        save.FileName = frmAtivo.Text + ".txt";
                        save.Filter = "Arquivo de Texto | *.txt";

                        if(save.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter writer = new StreamWriter(save.OpenFile());
                            for(int i = 0; i < txtUsuario.Lines.Count(); i++)
                            {
                                writer.WriteLine(txtUsuario.Lines[i]);
                            }
                            writer.Dispose();
                            writer.Close();
                            frmAtivo.Text = save.FileName;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTexto frmAbertura;
            if(this.ActiveMdiChild == null)
            {
                frmAbertura = new FrmTexto();
                frmAbertura.MdiParent = this;
                frmAbertura.ActiveControl = frmAbertura.txtTextoUsuario;

            }
            else
            {
                frmAbertura = (FrmTexto)this.ActiveMdiChild;
            }

            RichTextBox txtAbertura = (RichTextBox)frmAbertura.ActiveControl;

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivo de Texto | *.txt";

            if(open.ShowDialog()== DialogResult.OK)
            {
                StreamReader reader = new StreamReader(open.OpenFile());
                reader.Dispose();
                reader.Close();
                frmAbertura.Text = String.Format("{0}", open.FileName);
                frmAbertura.Show();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAtiva = this.ActiveMdiChild;
            if(frmAtiva !=null)
            {
                try
                {
                    RichTextBox txtBox = (RichTextBox)frmAtiva.ActiveControl;
                    if(txtBox != null)
                    {
                        if (txtBox.SelectedText != "")
                        {
                            Clipboard.SetText(txtBox.SelectedText, TextDataFormat.UnicodeText);
                        }
                        else
                        {
                            MessageBox.Show("Não há nada selecionado!", "Copiar");
                        }

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro");
                }
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAtiva = this.ActiveMdiChild;
            if (frmAtiva != null)
            {
                try
                {
                    RichTextBox txtBox = (RichTextBox)frmAtiva.ActiveControl;
                    if(txtBox != null)
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if(data.GetDataPresent(DataFormats.Text))
                        {
                            txtBox.SelectedText = data.GetData(DataFormats.Text).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ops, só consigo copiar textos", "Colar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Voce precisa selecionar uma janela");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro");
                }
            }
        }
    }
}
