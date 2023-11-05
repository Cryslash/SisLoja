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

        // --------- Variáveis --------- \\
        int X = 0;
        int Y = 0;


        // ------ Movimento da Janela com o mouse ------- //
        private void pTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void pTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            pTitle_MouseDown(sender, e);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            pTitle_MouseMove(sender, e);
        }

        private void lblVersion_MouseDown(object sender, MouseEventArgs e)
        {
            pTitle_MouseDown(sender, e);
        }

        private void lblVersion_MouseMove(object sender, MouseEventArgs e)
        {
            pTitle_MouseMove(sender, e);
        }
        // ---------------------------------------------- //

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            fRegister instanciaRegistro = new fRegister(this);
            instanciaRegistro.Owner = this;
            instanciaRegistro.TopLevel = false;            
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciaRegistro);
            instanciaRegistro.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            fConsultar instanciaConsulta = new fConsultar(this);
            instanciaConsulta.Owner = this;
            instanciaConsulta.TopLevel = false;
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciaConsulta);
            instanciaConsulta.Show();
        }
    }
}