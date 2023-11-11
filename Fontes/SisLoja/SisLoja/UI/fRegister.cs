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
        //criando uma nova instancia do formulario principal.
        public fPrincipal instanciaPrincipal;
        fCadCliente Cliente = new fCadCliente();
        fCadProduto cadastroProd = new fCadProduto();
        fCadEntrada cadastroEntrada = new fCadEntrada();


        //o metodo construtor recebe um parametro do tipo formulário principal.
        //o objetivo é passar o proprio formulário principal original para a nova
        //instancia criada anteriormente.
        public fRegister()
        {
            //passando o formulario principal para a nova instancia criada.
            InitializeComponent();            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente.Owner = instanciaPrincipal;
            Cliente.TopLevel = false;
            Cliente.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(Cliente);
            Cliente.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            cadastroProd.Owner = this.instanciaPrincipal;
            cadastroProd.TopLevel = false;
            cadastroProd.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(cadastroProd);
            cadastroProd.Show();
        }
                
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fCadEntrada>().Count() == 0)
                this.cadastroEntrada = new fCadEntrada();
            cadastroEntrada.Owner = this.instanciaPrincipal;
            cadastroEntrada.TopLevel = false;
            cadastroEntrada.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(cadastroEntrada);
            cadastroEntrada.Show();
            cadastroEntrada.tbPesquisa.Focus();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

        }
    }
}
