using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SisLoja.UI
{
    public partial class MenuLado : KryptonForm
    {
        public fPrincipal instanciaprincipal;
        public MenuLado()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            instanciaprincipal.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            instanciaprincipal.btnRegistrar_Click(sender, e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            instanciaprincipal.btnConsultar_Click(sender, e);
        }
    }
}
