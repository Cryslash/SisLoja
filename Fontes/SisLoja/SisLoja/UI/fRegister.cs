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
    public partial class fRegister : Form
    {
        public fPrincipal instanciaPrincipal;
        fCadCliente Cliente = new fCadCliente();
        fCadProduto cadastroProd = new fCadProduto();
        fCadEntrada cadastroEntrada = new fCadEntrada();

        public fRegister()
        {
            InitializeComponent();            
        }

        private void kbtnCliente_Click(object sender, EventArgs e)
        {
            Cliente.Owner = instanciaPrincipal;
            Cliente.TopLevel = false;
            Cliente.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(Cliente);
            Cliente.Show();
            Cliente.ktbNome.Focus();
        }

        private void kbtnProduto_Click(object sender, EventArgs e)
        {
            cadastroProd.Owner = this.instanciaPrincipal;
            cadastroProd.TopLevel = false;
            cadastroProd.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(cadastroProd);
            cadastroProd.Show();
        }
                
        private void kbtnEntrada_Click(object sender, EventArgs e)
        {
            cadastroEntrada.Owner = instanciaPrincipal;
            cadastroEntrada.TopLevel = false;
            cadastroEntrada.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(cadastroEntrada);
            cadastroEntrada.Show();
        }
    }
}
