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
        SqlConnection conexao;

        public string StringServer()
        {
            XML_DB_INFO xml = XML_DB_INFO.LoadFromFile("cfg.xml");
            string server = string.Format(@"Data Source={0};Initial Catalog=SisLoja;User Id={1};pwd={2};", xml.Server, xml.User, xml.Pass);
            return server;
        }

        public bool Apto_Cadastro(modeloProduto produto) 
        {
            try
            {
                string server = StringServer();
                string teste = "";
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT CodBar FROM Produtos WHERE CodBar = @cod", conexao);
                qrComando.Parameters.AddWithValue("@cod", produto.CodBar);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    teste = dados["CodBar"].ToString();
                }
                if (teste == "")
                    return true;
                return false;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Gravar_Produto(modeloProduto produto)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrcomando = new SqlCommand("INSERT INTO Produtos(CodBar,QrCode,Referencia,Img,Nome,Modelo,Cor,EstoqueMin,PrecoVenda)" +
                        " VALUES (@codbar,@qrcode,@ref,@img,@nome,@modelo,@cor,@min,@preco)", conexao);
                qrcomando.Parameters.AddWithValue("@codbar", produto.CodBar);
                qrcomando.Parameters.AddWithValue("@qrcode", produto.QrCode);
                qrcomando.Parameters.AddWithValue("@ref", produto.Ref);
                qrcomando.Parameters.AddWithValue("@img", produto.Img);
                qrcomando.Parameters.AddWithValue("@nome", produto.Nome);
                qrcomando.Parameters.AddWithValue("@modelo", produto.Modelo);
                qrcomando.Parameters.AddWithValue("@cor", produto.Cor);
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
        public void Iniciar_Estoque(modeloProduto produto)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("INSERT INTO Estoque (ProdID, QrCode, Cor) VALUES (@id,@qr,@cor)", conexao);
                qrComando.Parameters.AddWithValue("@id", produto.Id);
                qrComando.Parameters.AddWithValue("@qr", produto.QrCode);
                qrComando.Parameters.AddWithValue("@cor", produto.Cor);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
        public int Proximo_ID_Disponivel()
        {
            try
            {
                int id = 1;
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT TOP 1 ID FROM Produtos ORDER BY ID DESC", conexao);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    id = dados.GetInt32("ID") + 1;
                }
                conexao.Close();
                return id;
            }
            catch (Exception erro)
            {
                throw erro;
            }
           
        }

    }
}
