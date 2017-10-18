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

namespace Mon_Petit_Sucre.Forms
{
    public partial class ListaProdutos : Form
    {
        public ListaProdutos()
        {
            InitializeComponent();
            ValidaListaProdutos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.Text = "Adicionar Produto";
            frmProduto.ShowDialog();
            frmProduto.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.Text = "Atualizar Produto";
            frmProduto.ShowDialog();
            frmProduto.Dispose();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidaListaProdutos()
        {
            if(listViewProdutos.Items.Count == 0)
            {
                if(MessageBox.Show("A Lista está vazia, deseja cadastrar um novo produto ?", "Lista Vazia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                {
                    
                }
                else
                {
                    FrmProduto frmProduto = new FrmProduto();
                    frmProduto.Text = "Adicionar Produto";
                    frmProduto.ShowDialog();
                    frmProduto.Dispose();
                }
            }
        }
    }
}
