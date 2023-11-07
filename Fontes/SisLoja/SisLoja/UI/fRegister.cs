﻿using System;
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
        public fPrincipal instanciaPrincipal = new fPrincipal();
         
        //o metodo construtor recebe um parametro do tipo formulário principal.
        //o objetivo é passar o proprio formulário principal original para a nova
        //instancia criada anteriormente.
        public fRegister()
        {
            //passando o formulario principal para a nova instancia criada.
            InitializeComponent();            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fCadCliente Cliente = new fCadCliente();
            Cliente.Owner = instanciaPrincipal;
            Cliente.TopLevel = false;
            Cliente.AutoScroll = true;
            Cliente.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(Cliente);
            Cliente.Show();
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fCadProduto cadastroProd = new fCadProduto();
            cadastroProd.Owner = instanciaPrincipal;
            cadastroProd.TopLevel = false;
            cadastroProd.instanciaPrincipal = this.instanciaPrincipal;
            instanciaPrincipal.pDashArea.Controls.Clear();
            instanciaPrincipal.pDashArea.Controls.Add(cadastroProd);
            cadastroProd.Show();
        }
    }
}
