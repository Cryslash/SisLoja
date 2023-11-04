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
        fPrincipal instanciaprincipal = new fPrincipal();

        public fConsultar( fPrincipal p)
        {
            InitializeComponent();
            instanciaprincipal = p;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            fConCliente instanciaConsultar = new fConCliente();
            instanciaConsultar.Owner = instanciaprincipal;
            instanciaConsultar.TopLevel = false;
            instanciaprincipal.pDashArea.Controls.Clear();
            instanciaprincipal.pDashArea.Controls.Add(instanciaConsultar);
            instanciaConsultar.Show();
            
        }
    }
}
