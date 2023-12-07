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
        modeloProduto modeloproduto = new modeloProduto();
        modeloCliente cliente = new modeloCliente();
        modeloVenda dadosvenda = new modeloVenda();
        List<modeloListaDeProdutos> listaprodutos = new List<modeloListaDeProdutos>();
        bool locked = false;
        int numitens;
        decimal valorparcial, valortotal;

        public fVendas()
        {
            InitializeComponent();
        }

        //Limpar tbcodbar, tbqtd e tbnum
        private void Limpar_Campos()
        {
            tbCodBar.Text = "cód barras";
            tbQtd.Text = "qtd";
            tbNum.Text = "núm";
        }

        //Atualizar informações do painel direito
        private void Atualizar_Info(int qtd, decimal valor, string operacao)
        {
            if (operacao == "somar")
            {
                numitens++;
                valorparcial += valor * qtd;
                valortotal += valor * qtd;
            }
            if (operacao == "subtrair")
            {
                numitens--;
                valorparcial -= valor * qtd;
                valortotal -= valor * qtd;
            }

            lblNumItens.Text = string.Format("Número de Itens: {0}", numitens);
            lblValorParcial.Text = string.Format("Total Parcial: {0} R$", valorparcial);
            lblValorTotal.Text = string.Format("{0}", valortotal);
        }

        private void tbCodBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modeloproduto = BLL.BuscarProdutoDAL(tbCodBar.Text);
                pbImg.ImageLocation = modeloproduto.Img;
                lblProduto.Text = String.Format("{0} - {1} - {2}", modeloproduto.Nome, modeloproduto.Modelo, modeloproduto.Ref);
                lblPreco.Text = string.Format("R$ {0}", modeloproduto.PrecoVenda.ToString());
                tbNum.Focus();
            }
            else
            { 
                fVendas_KeyDown(sender, e);
            }
        }

        //Adicionar um produto a listaproduto
        public void AdicionarProduto(modeloProduto prod)
        {
            modeloListaDeProdutos itemlista = new modeloListaDeProdutos();
            Atualizar_Info(int.Parse(tbQtd.Text), prod.PrecoVenda, "somar");

            itemlista.Img = Image.FromFile(prod.Img);
            itemlista.Nome = String.Format("{0}-{1} {2} {3}-Num{4}", prod.CodBar, prod.Nome, prod.Modelo, prod.Ref, tbNum.Text);
            itemlista.Qtd = int.Parse(tbQtd.Text);
            itemlista.PrecoVenda = prod.PrecoVenda;
            listaprodutos.Add(itemlista);
        }

        //Remover um produto da listaproduto
        public void RemoverProduto(int i)
        {
            modeloListaDeProdutos itemlista = new modeloListaDeProdutos();
            itemlista = listaprodutos.ElementAt(i);
            Atualizar_Info(itemlista.Qtd, itemlista.PrecoVenda, "subtrair");
            listaprodutos.RemoveAt(i);
        }

        //Atualiza o DataSource do DtProdutos
        private void AtualizarDtProdutos()
        {
            BindingList<modeloListaDeProdutos> dados = new BindingList<modeloListaDeProdutos>(listaprodutos);
            dtProdutos.DataSource = dados;
        }

        private void tbQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // Verificando se o produto já existe no GridView, e caso exista, pegando
                    // a quantidade e salvando na variavel qtd.
                    int qtd = 0;
                    if (dtProdutos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dtProdutos.Rows)
                        {
                            if (row.Cells[1].Value != null)
                            {
                                string[] texto = row.Cells[2].FormattedValue.ToString().Split('-');
                                if (tbCodBar.Text == texto[0] && tbNum.Text == texto[2].Replace("Num", ""))
                                    qtd += int.Parse(row.Cells[3].Value.ToString());
                            }
                        }
                    }

                    //Executando o Método para verificar se o produto está disponível no estoque.
                    if (BLL.Numero_DisponivelDAL(tbCodBar.Text, int.Parse(tbNum.Text), int.Parse(tbQtd.Text) + qtd))
                    {
                        // modeloproduto.Qtd = Convert.ToInt32(tbQtd.Text);
                        // modeloproduto.Num = Convert.ToInt32(tbNum.Text);
                        AdicionarProduto(modeloproduto);
                        AtualizarDtProdutos();
                        Limpar_Campos();
                        tbCodBar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não existe quantidade suficiente em estoque.", "Mensagem do sistema.",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbQtd.Text = string.Empty;
                        tbQtd.Focus();
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("Erro ao processar a linha: " + erro.Message);
                }
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
            popCliente popupCliente = new popCliente();
            popupCliente.StartPosition = FormStartPosition.CenterScreen;
            popupCliente.cliente = this.cliente;
            popupCliente.fvendas = this;
            popupCliente.Show();
        }

        private void kbnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void dtProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtProdutos.CellClick += DataGridView_RemoverLinha;
        }


        private void DataGridView_RemoverLinha(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se o botão foi clicado e se não é o cabeçalho da coluna            
            if (e.RowIndex >= 0 && e.RowIndex < dtProdutos.Rows.Count && e.ColumnIndex == dtProdutos.Columns["acao"].Index && dtProdutos.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                if (locked == false)
                {
                    if (MessageBox.Show("Deseja remover o produto da lista?", "Mensagem do sistema.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemoverProduto(e.RowIndex);
                        AtualizarDtProdutos();
                        locked = true;
                        dtProdutos.Enabled = false;
                        Limpar_Campos();
                        tbCodBar.Focus();
                    }
                }
            }
        }
        //destrava o dtProdutos para remover uma linha
        private void pbUnlock_Click(object sender, EventArgs e)
        {
            locked = false;
            dtProdutos.Enabled = true;
        }

        private void kbnDesconto_Click(object sender, EventArgs e)
        {

        }

        private void kbnTipoPagamento_Click(object sender, EventArgs e)
        {
            popTipoPagamento popPgto = new popTipoPagamento();
            popPgto.StartPosition = FormStartPosition.CenterScreen;
            popPgto.dadosvenda = this.dadosvenda;
            popPgto.fvendas = this;
            popPgto.Show();
        }

        private void fVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                kbtnCliente.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
            }
            if (e.KeyCode == Keys.F4)
            {
                kbnTipoPagamento.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
            }
        }
    }
}
