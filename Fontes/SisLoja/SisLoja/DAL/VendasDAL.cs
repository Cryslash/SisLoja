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
                    produto.Id = int.Parse(dados["ID"].ToString());
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

        public bool Numero_Disponivel(string codbar, int num, int qtd)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT e.* FROM Estoque e, Produtos p WHERE e.ProdID = p.ID AND p.CodBar = @codbar", conexao);
                qrComando.Parameters.AddWithValue("@codbar", codbar);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    if (int.Parse(dados["Num"+num].ToString()) >= qtd)
                    return true;
                }
                return false;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public int Proximo_ID_Venda()
        {
            try
            {
                int id = 0;
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT TOP 1 ID FROM Vendas ORDER BY ID DESC", conexao);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read()) 
                {
                    id = Convert.ToInt32(dados["ID"]) + 1;
                }
                conexao.Close();
                return id;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public DataTable PesquisarCliente(string s)
        {
            try
            {
                DataTable dt = new DataTable();
                string server = StringServer();
                conexao = new SqlConnection (server);
                SqlCommand qrComando = new SqlCommand("SELECT ID,Nome,CPF FROM Clientes WHERE (Nome LIKE '%'+@nome+'%' OR CPF LIKE '%'+@cpf+'%') AND EstaAtivo = 1",conexao);
                qrComando.Parameters.AddWithValue("@nome", s);
                qrComando.Parameters.AddWithValue("@cpf", s);
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

        public void GravarVenda(modeloVenda dadosvenda, List<modeloListaDeProdutos> listaprodutos)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);

                string qr = "BEGIN TRANSACTION; INSERT INTO Vendas(ID,Data,";
                  if (dadosvenda.ClienteId != 0)
                    qr += "ClienteID,";

                qr += "TipoPagamento,ValorVenda,ValorPago,Descontos) VALUES(@id,@data,";
                if (dadosvenda.ClienteId != 0)
                    qr += "@clienteid,";

                qr += "@tipopgto,@valorvenda,@valorpago,@descontos);";
                foreach (modeloListaDeProdutos produto in listaprodutos)
                {
                    //dividindo a string Nome em 3 partes, a terceira parte(índice 2) possui a informação do número
                    //ex: 7890333910205 - Sandalia BeautyMoon 1020 - num38
                    string[] num = produto.Nome.Split('-');
                    qr += string.Format("INSERT INTO ItemsVenda (VendaID,ProdID,Num) VALUES({0},{1},{2});", dadosvenda.Id, produto.ID,
                        num[2].Replace("Num", ""));

                    qr += string.Format("UPDATE Estoque SET {0} = {0} - 1 WHERE ProdID = {1};", num[2], produto.ID);
                }
                qr += "COMMIT";

                SqlCommand qrComando = new SqlCommand(qr, conexao);
                qrComando.Parameters.AddWithValue("@id", dadosvenda.Id);
                qrComando.Parameters.AddWithValue("@data", DateTime.Now );
                qrComando.Parameters.AddWithValue("@clienteid", dadosvenda.ClienteId);
                qrComando.Parameters.AddWithValue("@tipopgto", dadosvenda.TipoPagamento);
                qrComando.Parameters.AddWithValue("@valorvenda", dadosvenda.ValorVenda);
                qrComando.Parameters.AddWithValue("@valorpago", dadosvenda.ValorPago);
                qrComando.Parameters.AddWithValue("@descontos", dadosvenda.Descontos);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable CarregarVendas()
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);

                SqlCommand qrComando = new SqlCommand("SELECT v.ID as Cód,v.Data,c.Nome as Cliente,v.TipoPagamento as Pagamento,v.ValorVenda,v.Descontos,v.ValorPago " +
                    "FROM Vendas v, Clientes c Where v.ClienteID = c.ID AND VendaCancelada = 0 ORDER BY v.ID DESC", conexao);
                DataTable dt = new DataTable();
                SqlDataAdapter dados = new SqlDataAdapter();
                dados.SelectCommand = qrComando;
                conexao.Open();
                dados.Fill(dt);
                conexao.Close();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable Pesquisar_Venda(string s)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT v.ID as Cód,v.Data,c.Nome as Cliente,v.TipoPagamento as Pagamento,v.ValorVenda,v.Descontos,v.ValorPago " +
                    "FROM Vendas v, Clientes c Where v.ClienteID = c.ID AND v.ID LIKE '%'+@id+'%' AND VendaCancelada = 0 ORDER BY v.ID DESC", conexao);
                qrComando.Parameters.AddWithValue("@id", s);
                DataTable dt = new DataTable();
                SqlDataAdapter dados = new SqlDataAdapter();
                dados.SelectCommand= qrComando;
                conexao.Open();
                dados.Fill(dt);
                conexao.Close();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public int Estornar_Venda(string id)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("UPDATE Vendas SET VendaCancelada = 1 WHERE ID = @id", conexao);
                qrComando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
                return 0;
            }
            catch (Exception erro)
            {
                return -1;
                throw erro;
            }
        }

        public DataTable Carregar_Produto(string id)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                String qr = "SELECT p.CodBar AS 'C. Barras', p.Nome AS 'Produto', iv.Num FROM ItemsVenda iv, Vendas v, Produtos p " +
                    "WHERE v.ID = iv.VendaID AND p.ID = iv.ProdID AND v.ID = @id;";
                SqlCommand qrComando = new SqlCommand(qr, conexao);
                qrComando.Parameters.AddWithValue("@id", id);
                SqlDataAdapter dados = new SqlDataAdapter();
                dados.SelectCommand = qrComando;
                DataTable dt = new DataTable();
                conexao.Open();
                dados.Fill(dt);
                conexao.Close();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
