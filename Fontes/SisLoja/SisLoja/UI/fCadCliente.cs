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
    public partial class fCadCliente : Form
    {
        public fPrincipal instanciaPrincipal;

        public fCadCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            instanciaPrincipal.btnCadastrar.PerformClick();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modeloCliente cliente = new modeloCliente();
            cliente.Data = DateTime.Now;
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

            ClienteBLL clienteBll = new ClienteBLL();
            int code = clienteBll.Gravar_ClienteDAL(cliente);
            if (code == 0)
            {
                MessageBox.Show("Cliente cadastrado com sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnVoltar.PerformClick();
            }
            if (code == 1)
              MessageBox.Show("Verifique os campos digitados.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (code == 2)  
            MessageBox.Show("Nome e telefone obrigatórios.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
