using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SisLoja
{
    class ProdutoDAL
    {
        SqlConnection conexao = null;

        public string StringServer()
        {
            XML_DB_INFO xml = XML_DB_INFO.LoadFromFile("cfg.xml");
            string server = string.Format(@"Data Source={0};Initial Catalog=SisLoja;User Id={1};pwd={2};", xml.Server, xml.User, xml.Pass);
            return server;
        }

        public void Gravar_Produto(modeloProduto produto)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrcomando = new SqlCommand("INSERT INTO Produtos(CodBar,QrCode,Referencia,Img,Nome,Modelo,EstoqueMin,PrecoVenda)" +
                        " VALUES (@codbar,@qrcode,@ref,@img,@nome,@modelo,@min,@preco)", conexao);
                qrcomando.Parameters.AddWithValue("@codbar", produto.CodBar);
                qrcomando.Parameters.AddWithValue("@qrcode", produto.QrCode);
                qrcomando.Parameters.AddWithValue("@ref", produto.Ref);
                qrcomando.Parameters.AddWithValue("@img", produto.Img);
                qrcomando.Parameters.AddWithValue("@nome", produto.Nome);
                qrcomando.Parameters.AddWithValue("@modelo", produto.Modelo);
                qrcomando.Parameters.AddWithValue("@min", produto.EstoqueMin);
                qrcomando.Parameters.AddWithValue("@preco", produto.PrecoVenda);
                conexao.Open();
                qrcomando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        
        }

    }
}
