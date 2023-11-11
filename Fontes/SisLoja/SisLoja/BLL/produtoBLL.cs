using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    class produtoBLL
    {
        ProdutoDAL DAL = new ProdutoDAL();
        public int Proximo_ID_DisponivelDAL() 
        {
            int id = DAL.Proximo_ID_Disponivel();
            return id;
        }
        public int Gravar_ProdutoDAL(modeloProduto produto)
        {
            //code 0: Sucesso;
            //code 1: Produto já Cadastrado;            
            //code 2: Verificar Campos;

            if (produto.Nome == String.Empty | produto.PrecoVenda == 0)
                return 2;
            if (DAL.Apto_Cadastro(produto))
            {
                DAL.Gravar_Produto(produto);
                DAL.Iniciar_Estoque(produto);
                return 0;
            }
            return 1;
        }
    }
}
