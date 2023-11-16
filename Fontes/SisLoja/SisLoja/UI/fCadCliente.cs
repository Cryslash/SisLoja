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
            instanciaPrincipal.btnRegistrar_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modeloCliente cliente = new modeloCliente();
            cliente.Data = DateTime.Now;
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

            ClienteBLL clienteBll = new ClienteBLL();
            int code = clienteBll.Gravar_ClienteDAL(cliente);
            if (code == 0)
            {
                MessageBox.Show("Cliente cadastrado com sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kbtnVoltar.PerformClick();
            }
            if (code == 1)
              MessageBox.Show("Verifique os campos digitados.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (code == 2)  
            MessageBox.Show("Nome e telefone obrigatórios.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
