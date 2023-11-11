using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SisLoja
{
    public class TerminalDAL
    {
        SqlConnection conexao = null;

        public string StringServer()
        {
            XML_DB_INFO xml = XML_DB_INFO.LoadFromFile("cfg.xml");
            string server = string.Format(@"Data Source={0};Initial Catalog=SisLoja;User Id={1};pwd={2};", xml.Server, xml.User, xml.Pass);
            return server;
        }

        public DataTable Verificar_Cores_E_Numeros(string qrcode)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT * FROM Estoque WHERE QrCode = @code", conexao);
                qrComando.Parameters.AddWithValue("@code", qrcode);
                DataTable dt = new DataTable();
                SqlDataAdapter dados = new SqlDataAdapter();
                dados.SelectCommand = qrComando;
                dados.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public modeloProduto Verificar_Info_Produto(string qrcode)
        {
            try
            {
                modeloProduto produto = new modeloProduto();
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT p.Nome, p.Modelo, p.Img, p.PrecoVenda " +
                    "FROM Estoque e, Produtos p " +
                    "WHERE e.QrCode = @code AND e.ProdID = p.ID", conexao);
                qrComando.Parameters.AddWithValue("@code", qrcode);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    produto.Nome = dados["Nome"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Img = dados["Img"].ToString();
                    produto.PrecoVenda = Convert.ToDecimal(dados["PrecoVenda"].ToString());
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
