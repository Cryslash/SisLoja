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
            if (kbtnConfirmar.Enabled != true)
            {
                dtClientes.ClearSelection();
                Desabilitar_Botoes();
            }
        }

        //----- Botões -----//

        public void Habilitar_Edicao() 
        {
            kbtnEditar.Enabled = true;
            kbtnExcluir.Enabled = true;
        }

        public void Habilitar_Acao()
        {
            kbtnConfirmar.Enabled = true;
            kbtnCancelar.Enabled = true;
        }

        public void Desabilitar_Botoes() 
        {
            kbtnEditar.Enabled=false;
            kbtnConfirmar.Enabled = false;
            kbtnCancelar.Enabled = false;
            kbtnExcluir.Enabled = false;                
        }

        //--- Campos ---//
        public void Habilitar_Campos() 
        {
            ktbNome.Enabled = true;
            ktbCpf.Enabled = true;
            ktbFone.Enabled = true;
            ktbWhatsapp.Enabled = true;
            ktbEmail.Enabled = true;
            ktbCep.Enabled = true;
            ktbRua.Enabled = true;
            ktbBairro.Enabled = true;
            ktbCidade.Enabled = true;
            kcbUf.Enabled = true;
            dtClientes.Enabled = false;
            ktbPesquisar.Enabled = false;
        }
        public void Desabilitar_Campos()
        {
            Limpar_Campos();
            ktbNome.Enabled = false;
            ktbCpf.Enabled = false;
            ktbFone.Enabled = false;
            ktbWhatsapp.Enabled = false;
            ktbEmail.Enabled = false;
            ktbCep.Enabled = false;
            ktbRua.Enabled = false;
            ktbBairro.Enabled = false;
            ktbCidade.Enabled = false;
            kcbUf.Enabled = false;
            dtClientes.Enabled = true;
            ktbPesquisar.Enabled = true;
        }

        public void Limpar_Campos()
        {
            ktbNome.Text = String.Empty;
            ktbCpf.Text = String.Empty;
            ktbFone.Text = String.Empty;
            ktbWhatsapp.Text = String.Empty;
            ktbEmail.Text = String.Empty;
            ktbCep.Text = String.Empty;
            ktbRua.Text = String.Empty;
            ktbBairro.Text = String.Empty;
            ktbCidade.Text = String.Empty;
            kcbUf.Text = "UF";
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
            ktbNome.Text = dtClientes.SelectedRows[0].Cells[1].Value.ToString();
            ktbCpf.Text = dtClientes.SelectedRows[0].Cells[2].Value.ToString();
            ktbFone.Text = dtClientes.SelectedRows[0].Cells[3].Value.ToString();
            ktbWhatsapp.Text = dtClientes.SelectedRows[0].Cells[4].Value.ToString();
            ktbEmail.Text = dtClientes.SelectedRows[0].Cells[5].Value.ToString();
            ktbCep.Text = dtClientes.SelectedRows[0].Cells[6].Value.ToString();
            ktbRua.Text = dtClientes.SelectedRows[0].Cells[7].Value.ToString();
            ktbBairro.Text = dtClientes.SelectedRows[0].Cells[8].Value.ToString();
            ktbCidade.Text = dtClientes.SelectedRows[0].Cells[9].Value.ToString();
            kcbUf.Text = dtClientes.SelectedRows[0].Cells[10].Value.ToString();

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
            cliente.Nome = ktbNome.Text;
            cliente.Cpf = ktbCpf.Text;
            cliente.Fone = ktbFone.Text;
            cliente.Whatsapp = ktbWhatsapp.Text;
            cliente.Email = ktbEmail.Text;
            cliente.Cep = ktbCep.Text;
            cliente.Rua = ktbRua.Text;
            cliente.Bairro = ktbBairro.Text;
            cliente.Cidade = ktbCidade.Text;
            cliente.Uf = kcbUf.Text;

            clienteBLL.Atualizar_ClienteDAL(cliente);
            Listar_Clientes();
            Desabilitar_Botoes();
            Desabilitar_Campos();
        }

        private void dtClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dtClientes.SelectedRows.Count == 1)
                kbtnEditar.PerformClick();
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            dtClientes.DataSource = clienteBLL.Pesquisar_ClienteDAL(ktbPesquisar.Text);
        }
    }
}
