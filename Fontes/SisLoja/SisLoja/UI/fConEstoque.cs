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
            btnEditar.Enabled= false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void Habilitar_Edicao()
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void Habilitar_Acao()
        {
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        // -------Campos ------//

         private void Habilitar_Campos() 
        {
            tbCor.Enabled = true;
            tbNome.Enabled = true;
            tbPreco.Enabled = true;
            tbModelo.Enabled = true;
            tbQrCode.Enabled = true;
            tbMin.Enabled = true;
            tbRef.Enabled = true;
            btnImg.Enabled = true;
            dtEstoque.Enabled = false;
            tbPesquisar.Enabled = false;
        }
        private void Desabilitar_Campos()
        {
            tbCor.Enabled = false;
            tbNome.Enabled = false;
            tbPreco.Enabled = false;
            tbModelo.Enabled = false;
            tbQrCode.Enabled = false;
            tbMin.Enabled = false;
            tbRef.Enabled = false;
            btnImg.Enabled = false;
            dtEstoque.Enabled = true;
            tbPesquisar.Enabled = true;
        }
        private void Limpar_Campos()
        {
            tbCodeBar.Text = string.Empty;
            tbCor.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbPreco.Text = string.Empty;
            tbModelo.Text = string.Empty;
            tbQrCode.Text = string.Empty;
            tbMin.Text = string.Empty;
            tbRef.Text = string.Empty;
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
            tbPesquisar.Focus();

        }
        private void fConEstoque_Load(object sender, EventArgs e)
        {
            Carregar_Estoque();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbCodeBar.Text = dtEstoque.SelectedRows[0].Cells[1].Value.ToString();
            tbQrCode.Text = dtEstoque.SelectedRows[0].Cells[2].Value.ToString();
            tbRef.Text = dtEstoque.SelectedRows[0].Cells[3].Value.ToString();
            tbNome.Text = dtEstoque.SelectedRows[0].Cells[4].Value.ToString();
            tbModelo.Text = dtEstoque.SelectedRows[0].Cells[5].Value.ToString();
            tbCor.Text = dtEstoque.SelectedRows[0].Cells[6].Value.ToString();
            tbMin.Text = dtEstoque.SelectedRows[0].Cells[7].Value.ToString();
            tbPreco.Text = dtEstoque.SelectedRows[0].Cells[8].Value.ToString();

            Desabilitar_Botoes();
            Habilitar_Acao();
            Habilitar_Campos();
            tbRef.Focus();
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
                btnEditar.PerformClick();
        }

        private void fConEstoque_Click(object sender, EventArgs e)
        {
            if (btnConfirmar.Enabled == false)
            {
                Desabilitar_Botoes();
                dtEstoque.ClearSelection();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            modeloProduto produto = new modeloProduto();
            produto.CodBar = tbCodeBar.Text;
            produto.QrCode = tbQrCode.Text;
            produto.Ref = tbRef.Text;
            produto.Nome = tbNome.Text;
            produto.Modelo = tbModelo.Text;
            produto.Cor = tbCor.Text;
            produto.Img = imgAtualizada;
            try
            {
            produto.EstoqueMin = Convert.ToInt32(tbMin.Text);
            produto.PrecoVenda = Convert.ToDecimal(tbPreco.Text);

            }
            catch{ }

            int code;
            if(MessageBox.Show("Confirma as Alterações no Produto?","Mensagem do Sistema",MessageBoxButtons.YesNo,
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
                if(code == 1)
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
            DataTable dt = BLL.Pesquisar_ProdutoDAL(tbPesquisar.Text);

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
            if(MessageBox.Show("Deseja Excluir o Produto?","Mensagem do Sistema",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLL.Excluir_ProdutoDAL(dtEstoque.SelectedRows[0].Cells[1].Value.ToString());
                Limpar_Campos();
                Desabilitar_Campos();
                Desabilitar_Botoes();
                Carregar_Estoque();
                dtEstoque.ClearSelection();
                tbPesquisar.Focus();
            }
        }
    }
}
