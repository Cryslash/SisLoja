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
                fvendas.lblTipoPgto.Visible = false;
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
            //tb.RightToLeft = RightToLeft.Yes;
            tb.TextAlign = HorizontalAlignment.Center;
            tb.ForeColor = Color.White;
            tb.BorderStyle = BorderStyle.None;

            this.pSkin.Controls.Add(tb);
            tb.Focus();
        }
    }
}
