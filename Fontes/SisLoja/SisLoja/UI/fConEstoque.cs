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
    public partial class fConEstoque : Form
    {
        public fPrincipal instanciaprincipal;
        produtoBLL BLL = new produtoBLL();
        string imgAtualizada = "";

        public fConEstoque()
        {
            InitializeComponent();
        }

        //-------Botoes -------//
        private void Desabilitar_Botoes()
        {
            kbtnEditar.Enabled = false;
            kbtnConfirmar.Enabled = false;
            kbtnCancelar.Enabled = false;
            kbtnExcluir.Enabled = false;
        }
        private void Habilitar_Edicao()
        {
            kbtnEditar.Enabled = true;
            kbtnExcluir.Enabled = true;
        }
        private void Habilitar_Acao()
        {
            kbtnConfirmar.Enabled = true;
            kbtnCancelar.Enabled = true;
        }
        // -------Campos ------//

        private void Habilitar_Campos()
        {
            ktbCor.Enabled = true;
            ktbNome.Enabled = true;
            ktbPreco.Enabled = true;
            ktbModelo.Enabled = true;
            ktbQrCode.Enabled = true;
            ktbMin.Enabled = true;
            ktbRef.Enabled = true;
            kbtnImg.Enabled = true;
            dtEstoque.Enabled = false;
            ktbPesquisar.Enabled = false;
        }
        private void Desabilitar_Campos()
        {
            ktbCor.Enabled = false;
            ktbNome.Enabled = false;
            ktbPreco.Enabled = false;
            ktbModelo.Enabled = false;
            ktbQrCode.Enabled = false;
            ktbMin.Enabled = false;
            ktbRef.Enabled = false;
            kbtnImg.Enabled = false;
            dtEstoque.Enabled = true;
            ktbPesquisar.Enabled = true;
        }
        private void Limpar_Campos()
        {
            ktbCodeBar.Text = string.Empty;
            ktbCor.Text = string.Empty;
            ktbNome.Text = string.Empty;
            ktbPreco.Text = string.Empty;
            ktbModelo.Text = string.Empty;
            ktbQrCode.Text = string.Empty;
            ktbMin.Text = string.Empty;
            ktbRef.Text = string.Empty;
        }

        private void Carregar_Estoque()
        {
            dtEstoque.Rows.Clear();
            Image img;
            DataTable dt = BLL.Carregar_EstoqueDAL();

            foreach (DataRow row in dt.Rows)
            {
                img = Image.FromFile(row[0].ToString());
                dtEstoque.Rows.Add(img, row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11],
                    row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24],
                    row[25], row[26], row[27], row[28], row[29], row[30], row[31], row[32], row[33], row[34], row[35]);
            }
            dtEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtEstoque.ClearSelection();
            ktbPesquisar.Focus();

        }
        private void fConEstoque_Load(object sender, EventArgs e)
        {
            Carregar_Estoque();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ktbCodeBar.Text = dtEstoque.SelectedRows[0].Cells[1].Value.ToString();
            ktbQrCode.Text = dtEstoque.SelectedRows[0].Cells[2].Value.ToString();
            ktbRef.Text = dtEstoque.SelectedRows[0].Cells[3].Value.ToString();
            ktbNome.Text = dtEstoque.SelectedRows[0].Cells[4].Value.ToString();
            ktbModelo.Text = dtEstoque.SelectedRows[0].Cells[5].Value.ToString();
            ktbCor.Text = dtEstoque.SelectedRows[0].Cells[6].Value.ToString();
            ktbMin.Text = dtEstoque.SelectedRows[0].Cells[7].Value.ToString();
            ktbPreco.Text = dtEstoque.SelectedRows[0].Cells[8].Value.ToString();

            Desabilitar_Botoes();
            Habilitar_Acao();
            Habilitar_Campos();
            ktbQrCode.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar_Campos();
            Desabilitar_Campos();
            Desabilitar_Botoes();
            dtEstoque.ClearSelection();
        }

        private void dtEstoque_Click(object sender, EventArgs e)
        {
            if (dtEstoque.SelectedRows.Count == 1)
            {
                Habilitar_Edicao();
            }
        }
        private void dtEstoque_DoubleClick(object sender, EventArgs e)
        {
            if (dtEstoque.SelectedRows.Count == 1)
                kbtnEditar.PerformClick();
        }

        private void fConEstoque_Click(object sender, EventArgs e)
        {
            if (kbtnConfirmar.Enabled == false)
            {
                Desabilitar_Botoes();
                dtEstoque.ClearSelection();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            modeloProduto produto = new modeloProduto();
            produto.CodBar = ktbCodeBar.Text;
            produto.QrCode = ktbQrCode.Text;
            produto.Ref = ktbRef.Text;
            produto.Nome = ktbNome.Text;
            produto.Modelo = ktbModelo.Text;
            produto.Cor = ktbCor.Text;
            produto.Img = imgAtualizada;
            try
            {
                produto.EstoqueMin = Convert.ToInt32(ktbMin.Text);
                produto.PrecoVenda = Convert.ToDecimal(ktbPreco.Text);

            }
            catch { }

            int code;
            if (MessageBox.Show("Confirma as Alterações no Produto?", "Mensagem do Sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoBLL BLL = new produtoBLL();
                code = BLL.Atualizar_ProdutoDAL(produto);
                if (code == 0)
                {
                    MessageBox.Show("Produto Atualizado com Sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Limpar_Campos();
                    Desabilitar_Campos();
                    Desabilitar_Botoes();
                    Carregar_Estoque();
                    dtEstoque.ClearSelection();
                    imgAtualizada = "";
                }
                if (code == 1)
                    MessageBox.Show("Verifique os Campos Informados.", "Mensagem do Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Title = "Abrir Imagem";
            janela.Filter = "All Files|*.*|JPG Image|*.jpg|PNG Image|*.png";
            if (janela.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgAtualizada = janela.FileName;
            }
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtEstoque.Rows.Clear();
            Image img;
            DataTable dt = BLL.Pesquisar_ProdutoDAL(ktbPesquisar.Text);

            foreach (DataRow row in dt.Rows)
            {
                img = Image.FromFile(row[0].ToString());
                dtEstoque.Rows.Add(img, row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11],
                    row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24],
                    row[25], row[26], row[27], row[28], row[29], row[30], row[31], row[32], row[33], row[34], row[35]);
            }
            dtEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtEstoque.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Produto?", "Mensagem do Sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLL.Excluir_ProdutoDAL(dtEstoque.SelectedRows[0].Cells[1].Value.ToString());
                Limpar_Campos();
                Desabilitar_Campos();
                Desabilitar_Botoes();
                Carregar_Estoque();
                dtEstoque.ClearSelection();
                ktbPesquisar.Focus();
            }
        }

        private void kbtnVoltar_Click(object sender, EventArgs e)
        {
            kbtnCancelar.PerformClick();
            this.instanciaprincipal.btnConsultar_Click(sender, e);
        }
    }
}
