using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    internal class VendasBLL
    {
        VendasDAL DAL = new VendasDAL();
        public modeloProduto BuscarProdutoDAL(string codbar)
        {
            modeloProduto produto = DAL.Buscar_Produto(codbar);
            return produto;
        }
    }
}
