using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisLoja;
using SisLoja.UI;

namespace SisLoja
{
    public partial class fPrincipal : Form
    {
        fHome instanciaHome = new fHome();

        public fPrincipal()
        {            
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            BtnClose.ForeColor = Color.LightGray;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.ForeColor = Color.Black;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            instanciaHome = new fHome();
            instanciaHome.Owner = this;
            instanciaHome.TopLevel = false;
            instanciaHome.AutoScroll = true;
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciaHome);
            instanciaHome.Show();

        }
    }
}