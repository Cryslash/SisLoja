using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SisLoja.UI
{
    public partial class fVendas : Form
    {
        public fPrincipal instanciaprincipal;
        VendasBLL BLL = new VendasBLL();
        modeloProduto produto = new modeloProduto();
        modeloCliente cliente = new modeloCliente();

        int numitens;
        decimal valorparcial, valortotal;

        public fVendas()
        {
            InitializeComponent();
        }

        private void Limpar_Campos()
        {
            tbCodBar.Text = "cód barras";
            tbQtd.Text = "qtd";
            tbNum.Text = "núm";
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
                lblProduto.Text = String.Format("{0} - {1} - {2}", produto.Nome, produto.Modelo, produto.Ref);
                lblPreco.Text = string.Format("R$ {0}", produto.PrecoVenda.ToString());
                tbNum.Focus();
            }
        }

        private void tbQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Image img = Image.FromFile(produto.Img);
                string info = string.Format("{0} - {1} {2} {3} - núm {4}", produto.CodBar, produto.Nome,
                    produto.Ref, produto.Modelo, tbNum.Text);
                dtListaProdutos.Rows.Add(img, info, tbQtd.Text, produto.PrecoVenda);
                Atualizar_Info(Convert.ToInt32(tbQtd.Text), produto.PrecoVenda);
                Limpar_Campos();
                tbCodBar.Focus();
            }
        }

        private void tbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNum.Text.Length > 0)
                    tbQtd.Focus();
            }
        }

        private void tbCodBar_Enter(object sender, EventArgs e)
        {
            tbCodBar.Text = string.Empty;
        }

        private void tbCodBar_Leave(object sender, EventArgs e)
        {
            if (tbCodBar.Text == string.Empty)
                tbCodBar.Text = "cód. barras";
        }

        private void tbNum_Enter(object sender, EventArgs e)
        {
            tbNum.Text = string.Empty;
        }

        private void tbNum_Leave(object sender, EventArgs e)
        {
            if (tbNum.Text == string.Empty)
                tbNum.Text = "núm";
        }

        private void tbQtd_Enter(object sender, EventArgs e)
        {
            tbQtd.Text = string.Empty;
        }

        private void tbQtd_Leave(object sender, EventArgs e)
        {
            if (tbQtd.Text == string.Empty)
                tbQtd.Text = "qtd";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void fVendas_Load(object sender, EventArgs e)
        {
            timer.Start();
            lblCodVenda.Text = string.Format("#00{0}", Convert.ToString(BLL.Proximo_ID_VendaDAL()));
        }

        private void kbtnCliente_Click(object sender, EventArgs e)
        {
            popCliente popup = new popCliente();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.cliente = this.cliente;
            popup.vendas = this;
            popup.ShowDialog();
        }
    }
}
