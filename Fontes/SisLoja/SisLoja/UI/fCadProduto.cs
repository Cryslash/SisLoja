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
    public partial class fCadProduto : Form
    {
        public fPrincipal instanciaPrincipal = null;
        

        public fCadProduto()
        {
            InitializeComponent();
        }

        private void btnQrCod_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator gen = new QRCoder.QRCodeGenerator();
            var dados = gen.CreateQrCode(tbQrCode.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrcode = new QRCoder.QRCode(dados);
            pbQrCod.Image = qrcode.GetGraphic(50);
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Title = "Abrir Imagem";
            janela.Filter = "All Files|*.*|JPG Image|*.jpg|PNG Image|*.png";
            if (janela.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbImg.Text = janela.FileName;
                pbImg.Image = Image.FromFile(janela.FileName);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            instanciaPrincipal.btnCadastrar.PerformClick();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modeloProduto produto = new modeloProduto();
            ProdutoDAL DAL = new ProdutoDAL();
            produto.Id = DAL.Proximo_ID_Disponivel(); 
            produto.CodBar = tbCodBar.Text;
            produto.QrCode = tbQrCode.Text;
            produto.Img = tbImg.Text;
            produto.Ref= tbRef.Text;
            produto.Nome = tbNome.Text;
            produto.Modelo = tbModelo.Text;
            produto.Cor = tbCor.Text;
            produto.EstoqueMin = Convert.ToInt32(tbMin.Text);
            produto.PrecoVenda = Convert.ToDecimal(tbPreco.Text);

            produtoBLL BLL = new produtoBLL();
            BLL.Gravar_ProdutoDAL(produto);
            MessageBox.Show("Produto cadastrado com sucesso.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnVoltar.PerformClick();
        }
    }
}
