using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SisLoja
{
    class produtoBLL
    {
        ProdutoDAL DAL = new ProdutoDAL();
        public DataTable Carregar_EstoqueDAL()
        {
            DataTable dt = DAL.Carregar_Estoque();
            return dt;        
        }
        public int Proximo_ID_DisponivelDAL() 
        {
            int id = DAL.Proximo_ID_Disponivel();
            return id;
        }
        public int Gravar_ProdutoDAL(modeloProduto produto)
        {
            //code 0: Sucesso;
            //code 1: Produto já Cadastrado;            
            //code 3: Verificar Campos;
            int code = DAL.Apto_Cadastro(produto);

            if (produto.Nome == String.Empty | produto.PrecoVenda == 0)
                return 3;
            if ( code == 0 )
            {
                DAL.Gravar_Produto(produto);
                return code;
            }
            return code;
        } 
        public int Atualizar_ProdutoDAL(modeloProduto produto)
        {
            //code 0: Sucesso;
            //code 1: Verificar Campos;

            if (produto.Nome == String.Empty | produto.PrecoVenda == 0)
                return 1;
            DAL.Atualizar_Produto(produto);
            return 0;            
            
        }
        public DataTable Pesquisar_ProdutoDAL(string s) 
        {
            DataTable dt = DAL.Pesquisar_Produto(s);
            return dt;
        }
        public void Excluir_ProdutoDAL(string code)
        {
            DAL.Excluir_Produto(code);
        }

        public DataTable Carregar_ProdutosDAL(string id)
        {
            DataTable dt = DAL.Carregar_Produto(id);
            return dt;
        }
        public int RetornarIDDAL(string codbar)
        {
            return DAL.RetornarId(codbar);
        }
        public void Fazer_TrocaDAL(modeloProduto produto, int codtroca, int codvenda)
        {
            DAL.Fazer_Troca(produto, codtroca, codvenda);
        }
    }
}
