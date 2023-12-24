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
    public partial class fConVendas : Form
    {
        public fPrincipal instanciaprincipal;
        VendasBLL BLL = new VendasBLL();

        public fConVendas()
        {
            InitializeComponent();
        }

        private void kbtnVoltar_Click(object sender, EventArgs e)
        {
            instanciaprincipal.btnConsultar_Click(sender, e);
        }

        private void CarregarVendas()
        {
            dtVendas.DataSource = BLL.CarregarVendasDAL();
            dtVendas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void fConVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void dtVendas_Click(object sender, EventArgs e)
        {
            if (dtVendas.SelectedRows.Count > 0)
            {
                kbtnEstornar.Enabled = true;
            }
        }

        private void fConVendas_Click(object sender, EventArgs e)
        {
            dtVendas.ClearSelection();
            kbtnEstornar.Enabled = false;
        }

        private void fConVendas_Shown(object sender, EventArgs e)
        {
            dtVendas.ClearSelection();
        }

        private void ktbPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtVendas.DataSource = BLL.Pesquisar_VendaDAL(ktbPesquisar.Text);
            dtVendas.ClearSelection();
        }
    }
}
