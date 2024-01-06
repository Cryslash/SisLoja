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
    public partial class fCfg : Form
    {
        public fPrincipal instanciaprincipal;

        public fCfg()
        {
            InitializeComponent();
        }

        private void Carregar_Impressoras()
        {
            kcbPrinter.Items.Clear();
            foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                kcbPrinter.Items.Add(impressora);
            }
        }

        private void fCfg_Load(object sender, EventArgs e)
        {
            Carregar_Impressoras();
        }
    }
}
