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
    public partial class fConCliente : Form
    {
        public fConCliente()
        {
            InitializeComponent();
        }

        public void Listar_Clientes()
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                dtClientes.DataSource = clienteBLL.Listar_ClientesDAL();
                dtClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Conexão com o banco de dados." + erro, "Mensagem do Sistema",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }


        private void fConCliente_Load(object sender, EventArgs e)
        {
            Listar_Clientes();
        }
    }
}
