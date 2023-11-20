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
    public partial class fConsultar : Form
    {
        public fPrincipal instanciaprincipal;
        fConCliente instanciaconcliente = new fConCliente();
        fConEstoque instanciaconestoque = new fConEstoque();

        public fConsultar()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            instanciaconcliente.Owner = instanciaprincipal;
            instanciaconcliente.TopLevel = false;
            instanciaconcliente.instanciaprincipal = this.instanciaprincipal;
            instanciaprincipal.pDashArea.Controls.Clear();
            instanciaprincipal.pDashArea.Controls.Add(instanciaconcliente);
            instanciaconcliente.Show();
            instanciaconcliente.Listar_Clientes();
            instanciaconcliente.ktbPesquisar.Focus();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            instanciaconestoque.Owner = instanciaprincipal;
            instanciaconestoque.TopLevel = false;
            instanciaconestoque.instanciaprincipal = this.instanciaprincipal;
            instanciaprincipal.pDashArea.Controls.Clear();
            instanciaprincipal.pDashArea.Controls.Add(instanciaconestoque);
            instanciaconestoque.Show();
            instanciaconestoque.ktbPesquisar.Focus();
        }
    }
}
