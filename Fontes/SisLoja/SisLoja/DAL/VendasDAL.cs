using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SisLoja
{
    internal class VendasDAL
    {

        SqlConnection conexao;
        public string StringServer()
        {
            XML_DB_INFO xml = XML_DB_INFO.LoadFromFile("cfg.xml");
            string server = string.Format(@"Data Source={0};Initial Catalog=SisLoja;User Id={1};pwd={2};", xml.Server, xml.User, xml.Pass);
            return server;
        }

        public modeloProduto Buscar_Produto(string codbar)
        {
            try
            {
                string server = StringServer();
                modeloProduto produto = new modeloProduto();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT p.*,e.* FROM Produtos p, Estoque e WHERE p.ID = e.ProdID AND p.CodBar = @codbar", conexao);
                qrComando.Parameters.AddWithValue("@codbar", codbar);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    produto.CodBar = codbar;
                    produto.Img = dados["Img"].ToString();
                    produto.Nome = dados["Nome"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Cor = dados["Cor"].ToString();
                    produto.Ref = dados["Referencia"].ToString();
                    produto.PrecoVenda = Convert.ToDecimal(dados["PrecoVenda"]);

                    for(int i = 18; i <= 44 ; i++)
                    {
                        // Construir o nome da propriedade usando um array e índice
                        string nomePropriedade = "Num" + i;
                        
                        // Utilizar Reflection para acessar a propriedade pelo nome construído
                        var propriedade = produto.GetType().GetProperty(nomePropriedade);

                        // Verificar se a propriedade existe antes de tentar atribuir valor
                        if (propriedade != null)
                            propriedade.SetValue(produto, Convert.ToInt32(dados[nomePropriedade]));
                    }
                }
                conexao.Close();
                return produto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
