using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SisLoja
{
    internal class TerminalBLL
    {
        TerminalDAL DAL = new TerminalDAL();

        public DataTable Verificar_Cores_E_NumerosDAL(string qrcode)
        {
            try
            {
                DataTable dt = DAL.Verificar_Cores_E_Numeros(qrcode);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public modeloProduto Verificar_Info_ProdutoDAL(string qrcode)
        {
            modeloProduto produto = DAL.Verificar_Info_Produto(qrcode);
            return produto;
        }
    }
}
