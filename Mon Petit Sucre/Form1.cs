using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mon_Petit_Sucre.Forms;

namespace Mon_Petit_Sucre
{
    public partial class Frm_Inicial : Form
    {
        public Frm_Inicial()
        {
            InitializeComponent();
        }

        private void Frm_Inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja encerrar o app ?", "Encerrar App", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProdutos frmListaProd = new ListaProdutos();
            frmListaProd.ShowDialog();
            frmListaProd.Dispose();
        }
    }
}
