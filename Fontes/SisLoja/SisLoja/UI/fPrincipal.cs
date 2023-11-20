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
using Krypton.Toolkit;

namespace SisLoja
{
    public partial class fPrincipal : KryptonForm
    {
        fHome instanciaHome;
        fRegister instanciaRegistro = new fRegister();
        public fConsultar instanciaconsultar = new fConsultar();
        fVendas instanciavenda = new fVendas();
        public fDashArea pDashArea = new fDashArea();

        public fPrincipal()
        {            
            InitializeComponent();
        }

        // --------- Variáveis --------- \\
        int X = 0;
        int Y = 0;

        
        // ------ Movimento da Janela com o mouse ------- //
        private void pSkin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void pSkin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
         //   pTitle_MouseDown(sender, e);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            pSkin_MouseMove(sender, e);
        }

        private void lblVersion_MouseDown(object sender, MouseEventArgs e)
        {
            pSkin_MouseDown(sender, e);
        }

        private void lblVersion_MouseMove(object sender, MouseEventArgs e)
        {
            pSkin_MouseMove(sender, e);
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
            fHome instanciaHome = new fHome();
            instanciaHome.Owner = this;
            instanciaHome.TopLevel = false;
            instanciaHome.AutoScroll = true;
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciaHome);
            instanciaHome.Show();

        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            instanciaRegistro.Owner = this;
            instanciaRegistro.TopLevel = false;
            instanciaRegistro.instanciaPrincipal = this;
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciaRegistro);
            instanciaRegistro.Show();
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {            
            instanciaconsultar.Owner = this;
            instanciaconsultar.TopLevel = false;
            instanciaconsultar.instanciaprincipal = this;
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciaconsultar);
            instanciaconsultar.Show();
        }

        private void btnCfg_Click(object sender, EventArgs e)
        {
            fTerminal terminal = new fTerminal();
            terminal.Show();
        }

        public void btnSales_Click(object sender, EventArgs e)
        {
            instanciavenda.Owner = this;
            instanciavenda.TopLevel = false;
            instanciavenda.instanciaprincipal = this;
            pDashArea.Controls.Clear();
            pDashArea.Controls.Add(instanciavenda);
            instanciavenda.Show();
            instanciavenda.tbCodBar.Focus();
        }

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            //carregar painel lado esquerdo
            MenuLado menu = new MenuLado();
            menu.TopLevel = false;
            menu.Location = new System.Drawing.Point(10, 15);
            menu.instanciaprincipal = this;
            this.pSkin.Controls.Add(menu);
            menu.Show();
            //carregar dasharea
            pDashArea.TopLevel = false;
            pDashArea.Location = new System.Drawing.Point(74, 28);
            pDashArea.instanciaprincipal = this;
            this.pSkin.Controls.Add(pDashArea);
            pDashArea.Show();

        }

       
    }
}