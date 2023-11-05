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
    public partial class fConCliente : Form
    {
        public fConCliente()
        {
            InitializeComponent();
        }

        public void Listar_Clientes()
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                dtClientes.DataSource = clienteBLL.Listar_ClientesDAL();
                dtClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Conexão com o banco de dados." + erro, "Mensagem do Sistema",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        private void fConCliente_Load(object sender, EventArgs e)
        {
            Listar_Clientes();
        }

        private void fConCliente_Shown(object sender, EventArgs e)
        {
            dtClientes.ClearSelection();
        }
        
        private void fConCliente_Click(object sender, EventArgs e)
        {
            if (btnConfirmar.Enabled != true)
            {
                dtClientes.ClearSelection();
                Desabilitar_Botoes();
            }
        }

        //----- Botões -----//

        public void Habilitar_Edicao() 
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        public void Habilitar_Acao()
        {
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void Desabilitar_Botoes() 
        {
            btnEditar.Enabled=false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;                
        }

        //--- Campos ---//
        public void Habilitar_Campos() 
        {
            tbNome.Enabled = true;
            tbCpf.Enabled = true;
            tbFone.Enabled = true;
            tbWhatsapp.Enabled = true;
            tbEmail.Enabled = true;
            tbCep.Enabled = true;
            tbRua.Enabled = true;
            tbBairro.Enabled = true;
            tbCidade.Enabled = true;
            cbUf.Enabled = true;
            dtClientes.Enabled = false;
            tbPesquisar.Enabled = false;
        }
        public void Desabilitar_Campos()
        {
            Limpar_Campos();
            tbNome.Enabled = false;
            tbCpf.Enabled = false;
            tbFone.Enabled = false;
            tbWhatsapp.Enabled = false;
            tbEmail.Enabled = false;
            tbCep.Enabled = false;
            tbRua.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            cbUf.Enabled = false;
            dtClientes.Enabled = true;
            tbPesquisar.Enabled = true;
        }

        public void Limpar_Campos()
        {
            tbNome.Text = String.Empty;
            tbCpf.Text = String.Empty;
            tbFone.Text = String.Empty;
            tbWhatsapp.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbCep.Text = String.Empty;
            tbRua.Text = String.Empty;
            tbBairro.Text = String.Empty;
            tbCidade.Text = String.Empty;
            cbUf.Text = "UF";
        }

        private void dtClientes_Click(object sender, EventArgs e)
        {
            if (dtClientes.SelectedRows.Count == 1)
            {
                Desabilitar_Botoes();
                Habilitar_Edicao();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Campos();
            Desabilitar_Botoes();
            Habilitar_Acao();
            tbNome.Text = dtClientes.SelectedRows[0].Cells[1].Value.ToString();
            tbCpf.Text = dtClientes.SelectedRows[0].Cells[2].Value.ToString();
            tbFone.Text = dtClientes.SelectedRows[0].Cells[3].Value.ToString();
            tbWhatsapp.Text = dtClientes.SelectedRows[0].Cells[4].Value.ToString();
            tbEmail.Text = dtClientes.SelectedRows[0].Cells[5].Value.ToString();
            tbCep.Text = dtClientes.SelectedRows[0].Cells[6].Value.ToString();
            tbRua.Text = dtClientes.SelectedRows[0].Cells[7].Value.ToString();
            tbBairro.Text = dtClientes.SelectedRows[0].Cells[8].Value.ToString();
            tbCidade.Text = dtClientes.SelectedRows[0].Cells[9].Value.ToString();
            cbUf.Text = dtClientes.SelectedRows[0].Cells[10].Value.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar_Campos();
            Desabilitar_Campos();
            Desabilitar_Botoes();
            dtClientes.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteBLL clienteBll = new ClienteBLL();
            modeloCliente cliente = new modeloCliente();
            cliente.Id = Convert.ToInt32(dtClientes.SelectedRows[0].Cells[0].Value);
            clienteBll.Excluir_ClienteDAL(cliente);
            MessageBox.Show("Cliente exluido com sucesso", "Mensagem do sistema", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar_Clientes();
            fConCliente_Click(sender, e);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            modeloCliente cliente = new modeloCliente();
            ClienteBLL clienteBLL = new ClienteBLL();

            cliente.Id = Convert.ToInt32(dtClientes.SelectedRows[0].Cells[0].Value);
            cliente.Nome = tbNome.Text;
            cliente.Cpf = tbCpf.Text;
            cliente.Fone = tbFone.Text;
            cliente.Whatsapp = tbWhatsapp.Text;
            cliente.Email = tbEmail.Text;
            cliente.Cep = tbCep.Text;
            cliente.Rua = tbRua.Text;
            cliente.Bairro = tbBairro.Text;
            cliente.Cidade = tbCidade.Text;
            cliente.Uf = cbUf.Text;

            clienteBLL.Atualizar_ClienteDAL(cliente);
            Listar_Clientes();
            Desabilitar_Botoes();
            Desabilitar_Campos();
        }

        private void dtClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dtClientes.SelectedRows.Count == 1)
                btnEditar.PerformClick();
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            dtClientes.DataSource = clienteBLL.Pesquisar_ClienteDAL(tbPesquisar.Text);
        }
    }
}
