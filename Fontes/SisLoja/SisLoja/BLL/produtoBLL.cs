using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    class produtoBLL
    {        
        ProdutoDAL DAL = null;

        public void Gravar_ProdutoDAL(modeloProduto produto)
        {
            DAL = new ProdutoDAL();
            DAL.Gravar_Produto(produto);
        }
    }
}
