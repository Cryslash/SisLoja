﻿using System;
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
        modeloCliente cliente = new modeloCliente();
        modeloProduto modeloproduto = new modeloProduto();
        public static modeloVenda dadosvenda = new modeloVenda();
        List<modeloListaDeProdutos> listaprodutos = new List<modeloListaDeProdutos>();
        bool locked = false;

        //variáveis
        public static int numitens, ConfirmaPagamento, numparcelas;
        public decimal valorparcial, valortotal, valordesconto;

        public fVendas()
        {
            InitializeComponent();
        }

        //Eventos do Form fVendas
        private void fVendas_Load(object sender, EventArgs e)
        {
            timer.Start();
            NovaVenda();
        }

        private void fVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                kbtnCliente.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                kbtnTipoPagamento.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                if (MessageBox.Show("Deseja Cancelar a Venda?","Mensagem do Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    NovaVenda();
            }
        }

        //Evento Relógio
        private void timer_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        //Realizar uma nova venda
        private void NovaVenda()
        {
            dtProdutos.Rows.Clear();
            cliente = new modeloCliente();
            modeloproduto = new modeloProduto();
            dadosvenda = new modeloVenda();
            listaprodutos = new List<modeloListaDeProdutos>();
            dadosvenda.Id = BLL.Proximo_ID_VendaDAL();
            lblCodVenda.Text = lblCodVenda.Text = string.Format("#00{0}", Convert.ToString(dadosvenda.Id));
            lblProduto.Text = "Produto";
            lblPreco.Text = "Preco";
            pbImg.Image = Image.FromFile("C:\\Users\\cryst\\Documents\\Projetos\\SistemaLoja\\Assets\\Images\\No-Image-Placeholder.png");
            lblValorTotal.Text = "0,00";
            lblDescricao.Text = "";
            lblNumItens.Text = "Número de Itens: 0";
            lblDesc.Text = "Descontos: R$ 0,00";
            lblValorParcial.Text = "Valor s/ Desc.: R$ 0,00";
            lblValorPago.Visible = false;
            lblValorPago.Text = "Valor Pago:";
            lblTroco.Visible = false;
            lblTroco.Text = "Troco:";
            kbtnTipoPagamento.Enabled = false;
            kbtnCancelarVenda.Enabled = false;

            numitens = 0;
            ConfirmaPagamento = 0;
            numparcelas = 1;
            valorparcial = 0;
            valortotal = 0;
            valordesconto = 0;
        }

        //Adicionar um produto a listaproduto
        public void AdicionarProduto(modeloProduto prod)
        {
            modeloListaDeProdutos itemlista = new modeloListaDeProdutos();
            Atualizar_Info(prod.PrecoVenda, "somar");

            itemlista.ID = prod.Id;
            itemlista.Img = Image.FromFile(prod.Img);
            itemlista.Nome = String.Format("{0}-{1} {2} {3}-Num{4}", prod.CodBar, prod.Nome, prod.Modelo, prod.Ref, tbNum.Text);
            itemlista.PrecoVenda = prod.PrecoVenda;
            listaprodutos.Add(itemlista);
        }

        //Remover um produto da listaproduto
        public void RemoverProduto(int i)
        {
            modeloListaDeProdutos itemlista = new modeloListaDeProdutos();
            itemlista = listaprodutos.ElementAt(i);
            Atualizar_Info(itemlista.PrecoVenda, "subtrair");
            listaprodutos.RemoveAt(i);
        }

        //Atualiza o DataSource do DtProdutos
        private void AtualizarDtProdutos()
        {
            BindingList<modeloListaDeProdutos> dados = new BindingList<modeloListaDeProdutos>(listaprodutos);
            dtProdutos.DataSource = dados;
            dtProdutos.Columns.Remove("ID");
        }

        //Comportamento das TextBoxes
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

        private void tbCodBar_Enter(object sender, EventArgs e)
        {
            tbCodBar.Text = string.Empty;
        }

        private void tbCodBar_Leave(object sender, EventArgs e)
        {
            if (tbCodBar.Text == string.Empty)
                tbCodBar.Text = "cód. barras";
        }

        private void tbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNum.Text.Length > 0)
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
                                    if (row.Cells[2].Value != null)
                                    {
                                        string[] texto = row.Cells[2].FormattedValue.ToString().Split('-');
                                        if (tbCodBar.Text == texto[0] && tbNum.Text == texto[2].Replace("Num", ""))
                                            qtd++;
                                    }
                                }
                            }

                            //Executando o Método para verificar se o produto está disponível no estoque.
                            if (BLL.Numero_DisponivelDAL(tbCodBar.Text, int.Parse(tbNum.Text), 1 + qtd))
                            {
                                AdicionarProduto(modeloproduto);
                                AtualizarDtProdutos();
                                Limpar_Campos();
                                kbtnTipoPagamento.Enabled = true;
                                kbtnCancelarVenda.Enabled = true;
                                tbCodBar.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Não existe quantidade suficiente em estoque.", "Mensagem do sistema.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                tbNum.Text = string.Empty;
                                tbNum.Focus();
                            }
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("Erro ao processar a linha: " + erro.Message);
                        }
                    }
                    else
                    {
                        fVendas_KeyDown(sender, e);
                    }
                }
                    
            }
            else
            {
                fVendas_KeyDown(sender, e);
            }
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

        //Limpar tbcodbar, tbqtd e tbnum
        private void Limpar_Campos()
        {
            tbCodBar.Text = "cód barras";
            tbNum.Text = "núm";
        }

        //destrava o dtProdutos para remover uma linha
        private void pbUnlock_Click(object sender, EventArgs e)
        {
            locked = false;
            dtProdutos.Enabled = true;
        }

        //remover linha do dtProdutos
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

        private void dtProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtProdutos.CellClick += DataGridView_RemoverLinha;
        }

        //Atualizar informações do painel direito
        private void Atualizar_Info(decimal valor, string operacao)
        {
            if (operacao == "somar")
            {
                numitens++;
                valorparcial += valor;
                valortotal += valor;
            }
            if (operacao == "subtrair")
            {
                numitens--;
                valorparcial -= valor;
                valortotal -= valor;
            }

            lblNumItens.Text = string.Format("Número de Itens: {0}", numitens);
            lblValorParcial.Text = string.Format("Valor s/ Desc.: R$ {0}", valorparcial);
            lblValorTotal.Text = string.Format("{0}", valortotal);
            if (lblValorPago.Visible == true)
            {
                lblValorPago.Visible = false;
                lblTroco.Visible = false;
                lblDescricao.Text = string.Format("Cliente: {0}", cliente.Nome);
            }
        }

        //botões painel direito.
        private void kbtnCliente_Click(object sender, EventArgs e)
        {
            dtProdutos.Visible = false;
            popCliente popupCliente = new popCliente();
            popupCliente.Location = new Point(280, 150);
            popupCliente.cliente = this.cliente;
            popupCliente.fvendas = this;
            popupCliente.Owner = this;
            popupCliente.TopLevel = false;
            pLista.Controls.Add(popupCliente);
            popupCliente.Show();
            popupCliente.ktbNome.Focus();
        }

        private void kbnDesconto_Click(object sender, EventArgs e)
        {

        }

        private void kbnTipoPagamento_Click(object sender, EventArgs e)
        {
            dtProdutos.Visible = false;
            popTipoPagamento popPgto = new popTipoPagamento();
            popPgto.Location = new Point(280, 150);
            popPgto.Owner = this;
            popPgto.TopLevel = false;
            popPgto.fvendas = this;
            pLista.Controls.Add(popPgto);
            popPgto.Show();
            popPgto.Focus();
        }

        public void FinalizarVenda()
        {
            if (dadosvenda.TipoPagamento == 3 || dadosvenda.TipoPagamento == 4 || dadosvenda.TipoPagamento == 5)
            {
                if (MessageBox.Show("Deseja encerrar a venda?", "Mensagem do Sistema", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmPagamento fpag = new FrmPagamento();
                    fpag.tipopagamento = dadosvenda.TipoPagamento;
                    fpag.valortotal = valortotal - valordesconto;
                    FrmPagamento.confirmapagamento = 0;
                    fpag.StartPosition = FormStartPosition.CenterParent;
                    fpag.ShowDialog(this);
                    if (FrmPagamento.confirmapagamento == 0)
                    {
                        GravarVenda();
                    }
                    else
                    {
                        MessageBox.Show("Transação não Autorizada. Cód: " + FrmPagamento.confirmapagamento, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (dadosvenda.TipoPagamento == 1 || dadosvenda.TipoPagamento == 2)
            {
                if (MessageBox.Show("Deseja encerrar a venda?", "Mensagem do Sistema", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    GravarVenda();
            }

        }

        private void GravarVenda()
        {           
            dadosvenda.Data = DateTime.Now;
            dadosvenda.ValorVenda = Convert.ToDecimal(valortotal);
            dadosvenda.Descontos = valordesconto;
            BLL.GravarVendaDAL(dadosvenda, listaprodutos);
            MessageBox.Show("Venda Realizada com Sucesso.", "Mensagem do Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NovaVenda();
        }
       
    }
}
