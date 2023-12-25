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
        VendasBLL BLL = new VendasBLL();

        public fConVendas()
        {
            InitializeComponent();
        }

        private void kbtnVoltar_Click(object sender, EventArgs e)
        {
            instanciaprincipal.btnConsultar_Click(sender, e);
        }

        private void CarregarVendas()
        {
            dtVendas.DataSource = BLL.CarregarVendasDAL();
            dtVendas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void fConVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void dtVendas_Click(object sender, EventArgs e)
        {
            if (dtVendas.SelectedRows.Count > 0)
            {
                Abilitar_Botoes();
                dtProdutos.DataSource = "";
                dtProdutos.DataSource = BLL.Carregar_ProdutosDAL(dtVendas.SelectedRows[0].Cells[0].Value.ToString());
                dtProdutos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void Abilitar_Botoes()
        { 
            kbtnEstornar.Enabled = true;
            kbtnTrocar.Enabled = true;
        }
        private void Desabilitar_Botoes()
        {
            kbtnEstornar.Enabled = false;
            kbtnTrocar.Enabled = false;
        }

        private void fConVendas_Click(object sender, EventArgs e)
        {
            dtVendas.ClearSelection();
            dtProdutos.DataSource = "";
            Desabilitar_Botoes();
        }

        private void fConVendas_Shown(object sender, EventArgs e)
        {
            dtVendas.ClearSelection();
        }

        private void ktbPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtVendas.DataSource = BLL.Pesquisar_VendaDAL(ktbPesquisar.Text);
            dtVendas.ClearSelection();
        }

        private void kbtnEstornar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Estornar a Venda?", "Mensagem do Sistema.", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmPagamento fpag = new FrmPagamento();
                fpag.tipopagamento = 0;
                fpag.estorno = true;
                fpag.valortotal = Convert.ToDecimal(dtVendas.SelectedRows[0].Cells[4].Value.ToString());
                FrmPagamento.confirmapagamento = 0;
                fpag.codestorno = dtVendas.SelectedRows[0].Cells[0].Value.ToString();
                fpag.StartPosition = FormStartPosition.CenterParent;
                fpag.ShowDialog(this);
                if (FrmPagamento.confirmapagamento == 0 && BLL.Estornar_VendaDAL(dtVendas.SelectedRows[0].Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("Estorno Realizado com Sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Ocorreu um Erro ao Processar o Estorno. Código: " + FrmPagamento.confirmapagamento, "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CarregarVendas();
                dtVendas.ClearSelection();
            }
        }
    }
}
