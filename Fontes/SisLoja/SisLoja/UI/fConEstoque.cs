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
    public partial class fConEstoque : Form
    {
        public fPrincipal instanciaprincipal;

        public fConEstoque()
        {
            InitializeComponent();
        }

        private void fConEstoque_Load(object sender, EventArgs e)
        {
            produtoBLL BLL = new produtoBLL();
            //Image img = Image.FromFile(dt.Rows[0][0].ToString());
            Image img;
            DataTable dt = BLL.Carregar_EstoqueDAL();
                       
          foreach (DataRow row in dt.Rows) 
            {
                img = Image.FromFile(row[0].ToString());
                dtEstoque.Rows.Add(img, row[1], row[2], row[3], row[4], row[5], row[6]);
            }        
            dtEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
