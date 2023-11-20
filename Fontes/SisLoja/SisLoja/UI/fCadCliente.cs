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

        private void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                // backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                // 0 - 9
                e.Handled = true;
            }
        }

        private void LimparCampos()
        { 
            ktbNome.Text = string.Empty;
            ktbCpf.Text = string.Empty;
            ktbFone.Text = string.Empty;
            ktbWhatsapp.Text = string.Empty;
            ktbEmail.Text = string.Empty;
            ktbCep.Text = string.Empty;
            ktbRua.Text = string.Empty;
            ktbBairro.Text = string.Empty;
            ktbCidade.Text = string.Empty;
            kcbUf.Text = "UF";
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
                LimparCampos();
                kbtnVoltar.PerformClick();
            }
            if (code == 1)
                MessageBox.Show("Nome e telefone obrigatórios.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
