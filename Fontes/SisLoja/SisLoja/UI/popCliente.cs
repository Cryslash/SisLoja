﻿using System;
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
    public partial class popCliente : KryptonForm
    {
        public fVendas fvendas;
        public modeloCliente cliente;
        VendasBLL BLL = new VendasBLL();

        public popCliente()
        {
            InitializeComponent();
        }

        private void ktbNome_TextChanged(object sender, EventArgs e)
        {
            dtCliente.DataSource = BLL.PesquisarClienteDAL(ktbNome.Text);
            dtCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void ktbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                kbtnConfirmar.PerformClick();
        }

        private void kbtnConfirmar_Click(object sender, EventArgs e)
        {
            if (dtCliente.SelectedRows.Count > 0)
            {
                cliente.Id = Convert.ToInt32(dtCliente.SelectedRows[0].Cells[0].Value.ToString());
                cliente.Nome = dtCliente.SelectedRows[0].Cells[1].Value.ToString();
                cliente.Cpf = dtCliente.SelectedRows[0].Cells[2].Value.ToString();

                fvendas.kbtnCancelarVenda.Enabled = true;
                this.Close();
            }
        }

        private void popCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            fvendas.dtProdutos.Visible = true;
            fVendas.dadosvenda.ClienteId = cliente.Id;
            fvendas.lblDescricao.Text = string.Format("Cliente: {0}",cliente.Nome);
            fvendas.tbCodBar.Focus();
        }

        private void popCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
