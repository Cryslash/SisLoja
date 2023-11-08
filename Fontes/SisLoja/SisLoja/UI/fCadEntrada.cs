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
            modeloProduto produto = BLL.Buscar_ProdutoDAL(tbPesquisa.Text);
            id = produto.Id;
            qrcode = produto.QrCode;
            tbCodBar.Text = produto.CodBar;
            tbNome.Text = produto.Nome;
            tbModelo.Text = produto.Modelo;
            tbCor.Text = produto.Cor;
            tbRef.Text = produto.Ref;
            pbImg.ImageLocation = produto.Img;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            instanciaPrincipal.btnCadastrar.PerformClick();
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbCodBar.Text != String.Empty)
            {
                modeloEntrada entrada = new modeloEntrada();
                entrada.ProdID = id;
                entrada.QrCode = qrcode;
                entrada.Data = DateTime.Now;
                entrada.Qtd = rtbQtd.Text; // exemplo 34:1,35:2,36:3,37:3,38:2,39:1
                entrada.Cor = tbCor.Text;
                int code = BLL.Gravar_EntradaDAL(entrada, tbPreco.Text);
                if (code == 0)
                    MessageBox.Show("Entrada realizada com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (code == 1)
                    MessageBox.Show("Falha ao registrar a entrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpar_Campos();
        }

        private void limpar_Campos()
        {
            tbPesquisa.Text = string.Empty;
            tbCodBar.Text = string.Empty;
            tbModelo.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbCor.Text = string.Empty;
            tbRef.Text = string.Empty;
            tbPreco.Text = string.Empty;
            rtbQtd.Text = string.Empty;
            pbImg.Image = Image.FromFile("C:\\Users\\cryst\\Documents\\Projetos\\SistemaLoja\\Assets\\Images\\No-Image-Placeholder.png");
        }
    }
}
