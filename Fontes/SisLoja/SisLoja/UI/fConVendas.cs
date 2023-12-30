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
    public partial class fConVendas : Form
    {
        public fPrincipal instanciaprincipal;
        public static int confirmapagamento;
        modeloProduto produto = new modeloProduto();
        VendasBLL VendaBLL = new VendasBLL();
        produtoBLL ProdutoBLL = new produtoBLL();

        bool estornarcartao = false;

        public fConVendas()
        {
            InitializeComponent();
        }

        private void kbtnVoltar_Click(object sender, EventArgs e)
        {
            if (kbtnCancelar.Enabled == true)
                kbtnCancelar.PerformClick();
            instanciaprincipal.btnConsultar_Click(sender, e);
        }

        public void CarregarVendas()
        {
            dtVendas.DataSource = VendaBLL.CarregarVendasDAL();
            dtVendas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            fConVendas_Click(this, new EventArgs());
        }

        private void fConVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void dtVendas_Click(object sender, EventArgs e)
        {
            if (dtVendas.SelectedRows.Count > 0)
            {
                Estornar_Cartao();
                kbtnEstornar.Enabled = true;
                dtProdutos.DataSource = "";
                dtProdutos.DataSource = ProdutoBLL.Carregar_ProdutosDAL(dtVendas.SelectedRows[0].Cells[0].Value.ToString());
                dtProdutos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dtProdutos.ClearSelection();
                kbtnTrocar.Enabled = false;
            }
        }
        private void dtProdutos_Click(object sender, EventArgs e)
        {
            kbtnTrocar.Enabled = true;
        }

        private void Estornar_Cartao()
        {
            DateTime datavenda = DateTime.Parse(dtVendas.SelectedRows[0].Cells[1].Value.ToString());
            int tipopgto = int.Parse(dtVendas.SelectedRows[0].Cells[3].Value.ToString());
            if (datavenda.Date == DateTime.Today && tipopgto != 1 && tipopgto != 2)
            {
                estornarcartao = true;
            }
            else
            {
                estornarcartao = false;
            }
        }

        private void Desabilitar_Botoes()
        {
            kbtnEstornar.Enabled = false;
            kbtnTrocar.Enabled = false;
        }
        private void Habilitar_Acao()
        {
            ktbPesquisar.Enabled = false;
            kbtnConfirmar.Enabled = true;
            kbtnCancelar.Enabled = true;
            dtVendas.Enabled = false;
            dtProdutos.Enabled = false;
        }
        private void Desabilitar_Acao()
        {
            ktbCodeBar.Text = string.Empty;
            ktbNum.Text = string.Empty;
            ktbPesquisar.Enabled = true;
            kbtnConfirmar.Enabled = false;
            kbtnCancelar.Enabled = false;
            dtVendas.Enabled = true;
            dtProdutos.Enabled = true;
            dtProdutos.ClearSelection();
        }

        private void fConVendas_Click(object sender, EventArgs e)
        {
            if (dtVendas.Enabled == true && dtProdutos.Enabled == true)
            {
                dtVendas.ClearSelection();
                dtProdutos.DataSource = "";
                ktbCodeBar.Text = "";
                ktbCodeBar.Enabled = false;
                ktbNum.Text = "";
                ktbNum.Enabled = false;
                Desabilitar_Botoes();
                estornarcartao = false;
            }
        }

        private void fConVendas_Shown(object sender, EventArgs e)
        {
            dtVendas.ClearSelection();
        }

        private void ktbPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtVendas.DataSource = VendaBLL.Pesquisar_VendaDAL(ktbPesquisar.Text);
            dtVendas.ClearSelection();
        }

        private void kbtnEstornar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Estornar a Venda?", "Mensagem do Sistema.", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (estornarcartao == true)
                {
                    FrmPagamento fpag = new FrmPagamento();
                    fpag.tipopagamento = 0;
                    fpag.estorno = true;
                    fpag.valortotal = Convert.ToDecimal(dtVendas.SelectedRows[0].Cells[4].Value.ToString());
                    FrmPagamento.confirmapagamento = 0;
                    fpag.codestorno = dtVendas.SelectedRows[0].Cells[0].Value.ToString();
                    fpag.StartPosition = FormStartPosition.CenterParent;
                    fpag.ShowDialog(this);
                    if (FrmPagamento.confirmapagamento == 0 && VendaBLL.Estornar_VendaDAL(dtVendas.SelectedRows[0].Cells[0].Value.ToString()) == 0)
                    {
                        MessageBox.Show("Estorno Realizado com Sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um Erro ao Processar o Estorno. Código: " + FrmPagamento.confirmapagamento, "Mensagem do Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (VendaBLL.Estornar_VendaDAL(dtVendas.SelectedRows[0].Cells[0].Value.ToString()) == 0)
                        MessageBox.Show("Estorno Realizado com Sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CarregarVendas();
                dtVendas.ClearSelection();
            }
        }

        private void kbtnTrocar_Click(object sender, EventArgs e)
        {
            Desabilitar_Botoes();
            Habilitar_Acao();
            ktbCodeBar.Enabled = true;
            ktbNum.Enabled = true;
            ktbCodeBar.Focus();
        }

        private void Fazer_Troca()
        {
            if (VendaBLL.Numero_DisponivelDAL(ktbCodeBar.Text, int.Parse(ktbNum.Text), 1))
            {
                if (MessageBox.Show("Deseja Realizar a Troca?", "Mensagem do Sistema.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //produto a ser entregue
                    produto.CodBar = ktbCodeBar.Text;
                    produto.Num = int.Parse(ktbNum.Text);
                    int id = ProdutoBLL.RetornarIDDAL(produto.CodBar);
                    if (id > 0)
                        produto.Id = id;

                    int codtroca = int.Parse(dtProdutos.SelectedRows[0].Cells[0].Value.ToString());
                    int codvenda = int.Parse(dtVendas.SelectedRows[0].Cells[0].Value.ToString());
                    //(produto a ser entregue, produto recolhido, codigo da venda)
                    ProdutoBLL.Fazer_TrocaDAL(produto, codtroca, codvenda);
                    CarregarVendas();
                }
            }
        }

        private void ktbCodeBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ktbNum.Focus();
            }
        }

        private void ktbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fazer_Troca();
            }
        }

        private void kbtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar_Acao();            
        }
    }
}
