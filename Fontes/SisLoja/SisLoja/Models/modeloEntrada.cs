using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    public class modeloEntrada
    {
        int id, prodid;
        string cor, qtd, qrcode;
        decimal valor;
        DateTime data;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int ProdID
        {
            get { return prodid; }
            set { prodid = value; }
        }
        public string Qtd 
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string QrCode
        {
            get { return qrcode; }
            set { qrcode = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
