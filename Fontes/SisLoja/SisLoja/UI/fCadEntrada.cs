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
    public partial class fCadEntrada : Form
    {
        public fPrincipal instanciaPrincipal;
        int id;
        string qrcode;

        EntradaBLL BLL = new EntradaBLL();

        public fCadEntrada()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            modeloProduto produto = BLL.Buscar_ProdutoDAL(ktbPesquisa.Text);
            id = produto.Id;
            qrcode = produto.QrCode;
            ktbCodBar.Text = produto.CodBar;
            ktbNome.Text = produto.Nome;
            ktbModelo.Text = produto.Modelo;
            ktbCor.Text = produto.Cor;
            ktbRef.Text = produto.Ref;
            pbImg.ImageLocation = produto.Img;
            ktbPreco.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            instanciaPrincipal.btnRegistrar_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ktbCodBar.Text != String.Empty)
            {
                modeloEntrada entrada = new modeloEntrada();
                entrada.ProdID = id;
                entrada.QrCode = qrcode;
                entrada.Data = DateTime.Now;
                entrada.Qtd = krtbQtd.Text; // exemplo 34:1,35:2,36:3,37:3,38:2,39:1
                entrada.Cor = ktbCor.Text;
                try
                {
                    entrada.Valor = Convert.ToDecimal(ktbPreco.Text);
                }
                catch
                { }

                if (MessageBox.Show("Deseja Realizar a Entrada dos Produtos?", "Mensagem do Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int code = BLL.Gravar_EntradaDAL(entrada, ktbPreco.Text);
                    if (code == 0)
                    {
                        MessageBox.Show("Entrada realizada com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar_Campos();
                    }
                    if (code == 1)
                        MessageBox.Show("Verificar os Campos Informados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpar_Campos()
        {
            ktbPesquisa.Text = string.Empty;
            ktbCodBar.Text = string.Empty;
            ktbModelo.Text = string.Empty;
            ktbNome.Text = string.Empty;
            ktbCor.Text = string.Empty;
            ktbRef.Text = string.Empty;
            ktbPreco.Text = string.Empty;
            krtbQtd.Text = string.Empty;
            pbImg.Image = Image.FromFile("C:\\Users\\cryst\\Documents\\Projetos\\SistemaLoja\\Assets\\Images\\No-Image-Placeholder.png");
        }

        private void ktbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                kbtnPesquisa.PerformClick();
        }
    }
}
