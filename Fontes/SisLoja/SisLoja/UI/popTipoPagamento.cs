using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SisLoja.UI
{
    public partial class popTipoPagamento : KryptonForm
    {
        public modeloVenda dadosvenda;
        public fVendas fvendas;
        
        public popTipoPagamento()
        {
            InitializeComponent();
        }

        private void popTipoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            //1-dinheiro
            //2-pix
            //3-crédito
            //4-débito
            if (e.KeyCode == Keys.D1)
            {
                dadosvenda.TipoPagamento = 1;
                TelaValor();
                //this.Close();
            }
            if (e.KeyCode == Keys.D2)
            {
                dadosvenda.TipoPagamento = 2;
                this.Close();
            }
            if (e.KeyCode == Keys.D3)
            {
                dadosvenda.TipoPagamento = 3;
                this.Close();
            }
            if (e.KeyCode == Keys.D4)
            {
                dadosvenda.TipoPagamento = 4;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                dadosvenda.TipoPagamento = 0;
                this.Close();
            }
        }

        private string CodigoVenda(int cod)
        {
            if (cod == 1) return "dinheiro";
            if (cod == 2) return "pix";
            if (cod == 3) return "crédito";
            if (cod == 4) return "débito";
            return "inválido";
        }

        private void popTipoPagamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dadosvenda.TipoPagamento > 0)
            {
                fvendas.lblDescricao.Text = string.Format("Forma de Pagamento: {0}", CodigoVenda(dadosvenda.TipoPagamento));
                //fvendas.lblTipoPgto.Text = string.Format("Forma de Pagamento: {0}", CodigoVenda(dadosvenda.TipoPagamento));
                //fvendas.lblTipoPgto.Visible = true;
            }
            else
            {
                fvendas.lblValorPago.Visible = false;
            }
            fvendas.dtProdutos.Visible = true;
        }

        private void TBTextChanged(object sender, EventArgs e)
        {
            // 10,501
            bool tirarzero = false;
            //if (((TextBox)sender).Text[0] == '0' && ((TextBox)sender).Text.Length >= 4)
            if (((TextBox)sender).Text[3] == '0' && ((TextBox)sender).Text.Length >= 7)
            {
                tirarzero = true;
            }

            string texto = ((TextBox)sender).Text.Replace(",","").Replace("R$ ","");
            if (tirarzero)
                texto = texto.Substring(1);
            string textocorrigido = texto;

            if (texto.Length < 3)
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    textocorrigido = string.Format("0{0}", texto);
                }
            }

            StringBuilder builder = new StringBuilder(textocorrigido);
            int posicaovirgula = builder.Length - 2;

            builder.Insert(posicaovirgula, ",");
            string textofinal = string.Format("R$ {0}",builder.ToString());
            
            ((TextBox)sender).Text = textofinal;
            ((TextBox)sender).SelectionStart = textofinal.Length;
        }

        private void TBKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dadosvenda.ValorPago = Convert.ToDecimal(((TextBox)sender).Text.Replace("R$ ",""));
                fvendas.lblValorPago.Visible = true;
                fvendas.lblValorPago.Text = string.Format("Valor Pago: R$ {0}",dadosvenda.ValorPago.ToString());
                fvendas.lblTroco.Visible = true;
                fvendas.lblTroco.Text = string.Format("Troco: R$ {0}", dadosvenda.ValorPago - Convert.ToDecimal(fvendas.lblValorTotal.Text));
                fvendas.kbtnFinalizar.Enabled = true;
                this.Close();
            }
        }

        private void TelaValor()
        {
            lblDinheiro.Visible = false;
            lblPix.Visible = false;
            lblCredito.Visible = false;
            lblDebito.Visible = false;

            TextBox tb = new TextBox();
            
            tb.Size = new Size(287, 23);
            tb.Location = new Point(48, 83);
            tb.Font = new Font("Segoe UI", 19, FontStyle.Bold);
            tb.BackColor = Color.FromArgb(37, 77, 113);
            tb.TextAlign = HorizontalAlignment.Center;
            tb.ForeColor = Color.White;
            tb.BorderStyle = BorderStyle.None;
            tb.Text = "R$ 0,00";
            tb.SelectionStart = tb.Text.Length;
            tb.TextChanged += TBTextChanged;
            tb.KeyDown += TBKeyDown;
            
            this.pSkin.Controls.Add(tb);
            tb.Focus();
        }
    }
}
