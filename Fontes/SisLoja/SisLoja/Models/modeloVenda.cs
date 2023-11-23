using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    internal class modeloVenda
    {
        int id, clienteid, tipopagamento;
        decimal valor, descontos;
        DateTime data;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public int ClienteId
        {
            get { return clienteid; }
            set { clienteid = value; }
        }
        public int TipoPagamento
        {
            get { return tipopagamento; }
            set { tipopagamento = value; }
        }
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }        
        }
        public decimal Descontos
        {
            get { return descontos; }
            set { descontos = value; }
        }
    }
}
