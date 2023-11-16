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
        string imgpath;

        public fCadProduto()
        {
            InitializeComponent();
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Title = "Abrir Imagem";
            janela.Filter = "All Files|*.*|JPG Image|*.jpg|PNG Image|*.png";
            if (janela.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgpath = janela.FileName;
                pbImg.Image = Image.FromFile(janela.FileName);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            instanciaPrincipal.btnRegistrar_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modeloProduto produto = new modeloProduto();
            produtoBLL BLL = new produtoBLL();
            produto.Id = BLL.Proximo_ID_DisponivelDAL(); 
            produto.CodBar = ktbCodBar.Text;
            produto.QrCode = ktbQrCode.Text;
            produto.Img = imgpath;
            produto.Ref= ktbRef.Text;
            produto.Nome = ktbNome.Text;
            produto.Modelo = ktbModelo.Text;
            produto.Cor = ktbCor.Text;
            try
            {
                produto.PrecoVenda = Convert.ToDecimal(ktbPreco.Text);
                produto.EstoqueMin = Convert.ToInt32(ktbMin.Text);
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
                    kbtnVoltar.PerformClick();
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
                        kbtnVoltar.PerformClick();
                    }
                if (code == 3)
                    MessageBox.Show("Verificar os Campos Informados.", "Erro do Sistema.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar_Campos()
        {
            ktbNome.Text = String.Empty;
            ktbModelo.Text = String.Empty;
            ktbRef.Text = String.Empty;
            ktbCor.Text = String.Empty;
            ktbMin.Text = String.Empty;
            ktbPreco.Text = String.Empty;
            ktbCodBar.Text = String.Empty;
            ktbQrCode.Text = String.Empty;
            pbImg.Image = Image.FromFile("C:\\Users\\cryst\\Documents\\Projetos\\SistemaLoja\\Assets\\Images\\No-Image-Placeholder.png");
        }

        private void tbCodBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.kbtnSalvar.PerformClick();
        }

        private void tbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 | e.KeyChar == 44)
            { 
                 // . e ,
            } else if (e.KeyChar == 8)
            {
                // backspace
            } else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            { 
                // 0 - 9
                e.Handled = true;
            }
        }

        private void tbMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled= true;
            }
        }

        private void ktbQrCode_Leave(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator gen = new QRCoder.QRCodeGenerator();
            var dados = gen.CreateQrCode(ktbQrCode.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrcode = new QRCoder.QRCode(dados);
            pbQrCod.Image = qrcode.GetGraphic(50);
        }
    }
}
