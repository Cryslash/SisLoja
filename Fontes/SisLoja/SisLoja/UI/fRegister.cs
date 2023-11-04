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
        fPrincipal instanciaPrincipal = new fPrincipal();
         
        //o metodo construtor recebe um parametro do tipo formulário principal.
        //o objetivo é passar o proprio formulário principal original para a nova
        //instancia criada anteriormente.
        public fRegister( fPrincipal p)
        {
            //passando o formulario principal para a nova instancia criada. 
            this.instanciaPrincipal = p;
            InitializeComponent();            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fCadCliente Cliente = new fCadCliente(instanciaPrincipal);
            Cliente.Owner = instanciaPrincipal;
            Cliente.TopLevel = false;
            Cliente.AutoScroll = true;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(Cliente);
            Cliente.Show();
            
        }
    }
}
