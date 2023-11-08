using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SisLoja
{
    class EntradaDAL
    {
        SqlConnection conexao;
        public string StringServer()
        {
            XML_DB_INFO xml = XML_DB_INFO.LoadFromFile("cfg.xml");
            string server = string.Format(@"Data Source={0};Initial Catalog=SisLoja;User Id={1};pwd={2};", xml.Server, xml.User, xml.Pass);
            return server;
        }

        public modeloProduto Buscar_Produto(string s)
        {
            try
            {
                modeloProduto produto = new modeloProduto();
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT TOP 1 ID, CodBar, QrCode, Img, Nome, Modelo, Cor, Referencia FROM Produtos" +
                    " WHERE CodBar = @cod OR Referencia = @ref ORDER BY ID DESC", conexao);
                qrComando.Parameters.AddWithValue("@cod", s);
                qrComando.Parameters.AddWithValue("@ref", s);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    produto.Id = Convert.ToInt32(dados["ID"]);
                    produto.CodBar = dados["CodBar"].ToString();
                    produto.QrCode = dados["QrCode"].ToString();
                    produto.Img = dados["Img"].ToString();
                    produto.Nome = dados["Nome"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Cor = dados["Cor"].ToString();
                    produto.Ref = dados["Referencia"].ToString();
                }
                return produto;
            }
            catch (Exception erro)
            {
                throw erro;
            }

            
        }

        public int Gravar_Entrada(modeloEntrada entrada)
        {
            // code:0 Sucesso; code:1 Erro            
            try
            {
                string server = StringServer();
                conexao=new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("INSERT INTO Entradas (ProdID, Data, Qtd, Preco) VALUES (" +
                    " @prod, @data, @qtd, @valor)", conexao);
                qrComando.Parameters.AddWithValue("@prod", entrada.ProdID);
                qrComando.Parameters.AddWithValue("@data", entrada.Data);
                qrComando.Parameters.AddWithValue("@qtd", entrada.Qtd);
                qrComando.Parameters.AddWithValue("@valor", entrada.Valor);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        public void Atualizar_Estoque(modeloEntrada entrada)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                string[] array = entrada.Qtd.Split(',');

                string query = "UPDATE Estoque SET ";
                for (int i = 0; i < array.Length; i++)
                {
                    query = query + string.Format("{0} = {0} + {1}, ", "Num" + array[i].Substring(0, array[i].IndexOf(':')),
                        array[i].Substring(array[i].LastIndexOf(':') + 1));
                }
               // query = query.Substring(0, query.LastIndexOf(','));
                query = query + "Cor = @cor, QrCode = @qrcode WHERE ProdID = @id";
                SqlCommand qrComando = new SqlCommand(query, conexao);
                qrComando.Parameters.AddWithValue("@cor", entrada.Cor);
                qrComando.Parameters.AddWithValue("@qrcode", entrada.QrCode);
                qrComando.Parameters.AddWithValue("@id", entrada.ProdID);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
