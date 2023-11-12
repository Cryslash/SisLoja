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
            produtoBLL BLL = new produtoBLL();
            produto.Id = BLL.Proximo_ID_DisponivelDAL(); 
            produto.CodBar = tbCodBar.Text;
            produto.QrCode = tbQrCode.Text;
            produto.Img = tbImg.Text;
            produto.Ref= tbRef.Text;
            produto.Nome = tbNome.Text;
            produto.Modelo = tbModelo.Text;
            produto.Cor = tbCor.Text;
            try
            {
                produto.PrecoVenda = Convert.ToDecimal(tbPreco.Text);
                produto.EstoqueMin = Convert.ToInt32(tbMin.Text);
            }
            catch{ }
                        
            if( MessageBox.Show("Deseja Salvar o Produto.", "Mensagem do sistema.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               int code = BLL.Gravar_ProdutoDAL(produto);
                if (code == 0)
                {
                    MessageBox.Show("Produto Cadastrado Com Sucesso.", "Mensagem do Sistema.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar_Campos();
                    btnVoltar.PerformClick();
                }
                if (code == 1)
                    MessageBox.Show("O Produto já se Encontra Cadastrado.", "Mensagem do Sistema.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (code == 2)
                    if (MessageBox.Show("O Produto se Encontra Inativo! Deseja Ativa-lo Novamente?", "Mensagem do Sistema.",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("O Produto foi ativado Novamente.","Mensagem do Sistema.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BLL.Atualizar_ProdutoDAL(produto);
                        Limpar_Campos();
                        btnVoltar.PerformClick();
                    }
                if (code == 3)
                    MessageBox.Show("Verificar os Campos Informados.", "Erro do Sistema.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar_Campos()
        {
            tbImg.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbModelo.Text = String.Empty;
            tbRef.Text = String.Empty;
            tbCor.Text = String.Empty;
            tbMin.Text = String.Empty;
            tbPreco.Text = String.Empty;
            tbCodBar.Text = String.Empty;
            tbQrCode.Text = String.Empty;
            pbImg.Image = Image.FromFile("C:\\Users\\cryst\\Documents\\Projetos\\SistemaLoja\\Assets\\Images\\No-Image-Placeholder.png");
        }

        private void tbCodBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnSalvar.PerformClick();
        }
    }
}
