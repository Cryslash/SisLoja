using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    public class modeloVenda
    {
        int id, clienteid, tipopagamento;
        decimal valorvenda, descontos, valorpago;
        DateTime data;
        
        public int Id // --
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Data // --
        {
            get { return data; }
            set { data = value; }
        }
        public int ClienteId // --
        {
            get { return clienteid; }
            set { clienteid = value; }
        }
        public int TipoPagamento  // --
        {
            get { return tipopagamento; }
            set { tipopagamento = value; }
        }
        public decimal ValorVenda // --
        {
            get { return valorvenda; }
            set { valorvenda = value; }        
        }
        public decimal ValorPago
        {
            get { return valorpago; }
            set { valorpago = value; }
        }
        public decimal Descontos
        {
            get { return descontos; }
            set { descontos = value; }
        }
    }
}
