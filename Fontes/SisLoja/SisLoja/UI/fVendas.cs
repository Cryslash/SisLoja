using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLoja.UI
{
    public partial class fVendas : Form
    {
        public fPrincipal instanciaprincipal;
        VendasBLL BLL = new VendasBLL();
        modeloProduto produto = new modeloProduto();

        int numitens;
        decimal valorparcial, valortotal;

        public fVendas()
        {
            InitializeComponent();
        }

        private void Limpar_Campos() 
        {
            tbCodBar.Text = string.Empty;
            tbQtd.Text = string.Empty;
            tbNum.Text = string.Empty;
        }

        private void Atualizar_Info(int qtd, decimal valor)
        {
            numitens++;
            valorparcial += valor * qtd;
            valortotal += valor * qtd;

            lblNumItens.Text = string.Format("Número de Itens: {0}", numitens);
            lblValorParcial.Text = string.Format("Total Parcial: {0} R$", valorparcial);
            lblValorTotal.Text = string.Format("{0}", valortotal);
        }

        private void tbCodBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                produto = BLL.BuscarProdutoDAL(tbCodBar.Text);
                pbImg.ImageLocation = produto.Img;
                lblProduto.Text = String.Format("{0} - {1} - {2}",produto.Nome, produto.Modelo, produto.Ref);
                lblPreco.Text = string.Format("R$ {0}", produto.PrecoVenda.ToString());
                tbNum.Focus();
            }
        }

        private void tbQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Image img = Image.FromFile(produto.Img);
                string info = string.Format("{0} - {1} - num {2} - {3}", produto.Nome, produto.Modelo,tbNum.Text, produto.Ref);
                dtListaProdutos.Rows.Add(img, info,tbQtd.Text,produto.PrecoVenda);
                Atualizar_Info(Convert.ToInt32(tbQtd.Text), produto.PrecoVenda);
                Limpar_Campos();
                tbCodBar.Focus();
            }
        }

        private void tbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (tbNum.Text.Length > 0)
                    tbQtd.Focus();
            }
        }
    }
}
