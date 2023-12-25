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
        //public modeloVenda dadosvenda;
        public fVendas fvendas;

        public popTipoPagamento()
        {
            InitializeComponent();
        }

        private void popTipoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            //1-dinheiro
            //2-pix
            //3-crédito a vista
            //4-crédito parcelado
            //5-débito
            if (e.KeyCode == Keys.D1)
            {
                fVendas.dadosvenda.TipoPagamento = 1;
                fvendas.valordesconto = Math.Round(fvendas.valortotal * Convert.ToDecimal(0.10), 2);
                fvendas.lblDesc.Text = string.Format("Descontos: R$ {0}", fvendas.valordesconto);
                fvendas.lblValorTotal.Text = string.Format("{0}", fvendas.valortotal - fvendas.valordesconto);
                PagDinheiro();
            }
            if (e.KeyCode == Keys.D2)
            {
                fVendas.dadosvenda.TipoPagamento = 2;
                fvendas.valordesconto = Math.Round(fvendas.valortotal * Convert.ToDecimal(0.10), 2);
                fvendas.lblDesc.Text = string.Format("Descontos: R$ {0}", fvendas.valordesconto);
                fvendas.lblValorPago.Visible = false;
                fvendas.lblTroco.Visible = false;
                this.Close();
            }
            if (e.KeyCode == Keys.D3)
            {
                fVendas.dadosvenda.TipoPagamento = 3;
                fvendas.valordesconto = Math.Round(fvendas.valortotal * Convert.ToDecimal(0.05), 2);
                fvendas.lblDesc.Text = string.Format("Descontos: R$ {0}", fvendas.valordesconto);
                fvendas.lblValorPago.Visible = false;
                fvendas.lblTroco.Visible = false;
                this.Close();
            }
            if (e.KeyCode == Keys.D4)
            {
                fVendas.dadosvenda.TipoPagamento = 4;
                fvendas.lblValorPago.Visible = false;
                fvendas.lblTroco.Visible = false;
                PagCreditoParcelado();
                //this.Close();
            }
            if (e.KeyCode == Keys.D5)
            {
                fVendas.dadosvenda.TipoPagamento = 5;
                fvendas.valordesconto = Math.Round(fvendas.valortotal * Convert.ToDecimal(0.076), 2);
                fvendas.lblDesc.Text = string.Format("Descontos: R$ {0}", fvendas.valordesconto);
                fvendas.lblValorPago.Visible = false;
                fvendas.lblTroco.Visible = false;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                fVendas.dadosvenda.TipoPagamento = 0;
                this.Close();
            }
        }

        private string CodigoVenda(int cod)
        {
            if (cod == 1) return "dinheiro";
            if (cod == 2) return "pix";
            if (cod == 3) return "crédito a vista";
            if (cod == 4) return "crédito parcelado";
            if (cod == 5) return "débito";
            return "inválido";
        }

        private void popTipoPagamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fVendas.dadosvenda.TipoPagamento > 0)
            {
                fvendas.lblDescricao.Text = string.Format("Forma de Pagamento: {0}", CodigoVenda(fVendas.dadosvenda.TipoPagamento));
                fvendas.lblValorTotal.Text = string.Format("{0}", fvendas.valortotal - fvendas.valordesconto);
            }
            //else
            //{
            //    fvendas.lblValorPago.Visible = false;
            //}
            fvendas.dtProdutos.Visible = true;
            fvendas.tbCodBar.Focus();
        }
        private void popTipoPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            fvendas.FinalizarVenda();
        }

        private void PagDinheiroTextChanged(object sender, EventArgs e)
        {
            // 10,501
            bool tirarzero = false;
            //if (((TextBox)sender).Text[0] == '0' && ((TextBox)sender).Text.Length >= 4)
            if (((TextBox)sender).Text[3] == '0' && ((TextBox)sender).Text.Length >= 7)
            {
                tirarzero = true;
            }

            string texto = ((TextBox)sender).Text.Replace(",", "").Replace("R$ ", "");
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
            string textofinal = string.Format("R$ {0}", builder.ToString());

            ((TextBox)sender).Text = textofinal;
            ((TextBox)sender).SelectionStart = textofinal.Length;
        }

        private void PagDinheiroKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fVendas.dadosvenda.ValorPago = Convert.ToDecimal(((TextBox)sender).Text.Replace("R$ ", ""));
                fvendas.lblValorPago.Visible = true;
                fvendas.lblValorPago.Text = string.Format("Valor Pago: R$ {0}", fVendas.dadosvenda.ValorPago.ToString());
                fvendas.lblTroco.Visible = true;
                fvendas.lblTroco.Text = string.Format("Troco: R$ {0}", fVendas.dadosvenda.ValorPago + fvendas.valordesconto - fvendas.valorparcial);
                this.Close();
            }
        }

        private void PagCreditoParceladoKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fVendas.numparcelas = Convert.ToInt32(((TextBox)sender).Text);
                fvendas.valordesconto = 0;
                fvendas.lblDesc.Text = "Descontos: R$ 0,00";
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void PagDinheiro()
        {
            lblDinheiro.Visible = false;
            lblPix.Visible = false;
            lblCredito.Visible = false;
            lblParcelado.Visible = false;
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
            tb.TextChanged += PagDinheiroTextChanged;
            tb.KeyDown += PagDinheiroKeyDown;

            this.pSkin.Controls.Add(tb);
            tb.Focus();
        }

        private void PagCreditoParcelado()
        {
            lblDinheiro.Visible = false;
            lblPix.Visible = false;
            lblCredito.Visible = false;
            lblParcelado.Visible = false;
            lblDebito.Visible = false;

            Label lbl = new Label();
            lbl.Text = "Número de Parcelas";
            lbl.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lbl.ForeColor = Color.White;
            lbl.Size = new Size(207, 30);
            lbl.Location = new Point(48, 83);

            TextBox tb = new TextBox();
            tb.Size = new Size(50, 23);
            tb.Location = new Point(280, 83);
            tb.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            tb.BackColor = Color.FromArgb(37, 77, 113);
            //tb.TextAlign = HorizontalAlignment.Center;
            tb.ForeColor = Color.White;
            tb.BorderStyle = BorderStyle.None;
            tb.KeyDown += PagCreditoParceladoKeyDown;

            this.pSkin.Controls.Add(lbl);
            this.pSkin.Controls.Add(tb);
            tb.Focus();

        }

        
    }
}
