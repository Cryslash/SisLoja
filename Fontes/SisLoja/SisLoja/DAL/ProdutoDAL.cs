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
        public int Apto_Cadastro(modeloProduto produto) 
        {
            // code:0 Apto para cadastrar
            // code:1 Produto já existe.
            // code:2 Produto já existe e esta marcado como nao ativo
            try
            {
                string server = StringServer();
                string codbar = "";
                string ativo = "";
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT CodBar, EstaAtivo FROM Produtos WHERE CodBar = @cod", conexao);
                qrComando.Parameters.AddWithValue("@cod", produto.CodBar);
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    ativo = dados["EstaAtivo"].ToString();
                    codbar = dados["CodBar"].ToString();
                }
                if (codbar == "")
                {                   
                    return 0;
                }
                if (codbar != "" & ativo == "0")
                    return 2;
                return 1;
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
        public void Gravar_Produto(modeloProduto produto)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrcomando = new SqlCommand("BEGIN TRANSACTION; INSERT INTO Produtos(CodBar,QrCode,Referencia,Img,Nome,Modelo,Cor," +
                    "EstoqueMin,PrecoVenda) VALUES (@codbar,@qrcode,@ref,@img,@nome,@modelo,@cor,@min,@preco); INSERT INTO Estoque " +
                    "(ProdID, QrCode, Cor) VALUES (@id,@qrcode,@cor); COMMIT", conexao);
                qrcomando.Parameters.AddWithValue("@id", produto.Id);
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
        public void Atualizar_Produto(modeloProduto produto)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);

                string qr = "BEGIN TRANSACTION; UPDATE Produtos SET QrCode = @qrcode, Referencia = @ref, " +
                    "Nome = @nome, Modelo = @modelo, Cor = @cor, EstoqueMin = @min, PrecoVenda = @valor, EstaAtivo = 1";

                if (produto.Img != "" & produto.Img != null)
                    qr += ", Img = @img";

                qr += " FROM Produtos p, Estoque e WHERE p.CodBar = @cod AND p.ID = e.ProdID; UPDATE Estoque SET " +
                    "QrCode = @qrcode, Cor = @cor FROM Produtos p, Estoque e WHERE p.CodBar = @cod AND p.ID = e.ProdID; COMMIT";

                SqlCommand qrComando = new SqlCommand(qr, conexao);
                qrComando.Parameters.AddWithValue("@cod", produto.CodBar);
                qrComando.Parameters.AddWithValue("@qrcode", produto.QrCode);
                qrComando.Parameters.AddWithValue("@ref", produto.Ref);

                if(produto.Img != "" & produto.Img != null)
                    qrComando.Parameters.AddWithValue("@img", produto.Img);
                
                qrComando.Parameters.AddWithValue("@nome", produto.Nome);
                qrComando.Parameters.AddWithValue("@modelo", produto.Modelo);
                qrComando.Parameters.AddWithValue("@cor", produto.Cor);
                qrComando.Parameters.AddWithValue("@min", produto.EstoqueMin);
                qrComando.Parameters.AddWithValue("@valor", produto.PrecoVenda);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable Carregar_Estoque()
        {
            try
            {
                DataTable dt = new DataTable();
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT p.Img,p.CodBar,p.QrCode,p.Referencia,p.Nome,p.Modelo,p.Cor,p.EstoqueMin,p.PrecoVenda," +
                    " e.Num44,e.Num43,e.Num42,e.Num41,e.Num40,e.Num39,e.Num38,e.Num37,e.Num36,e.Num35,e.Num34,e.Num33,e.Num32,e.Num31,e.Num30,e.Num29," +
                    "e.Num28,e.Num27,e.Num26,e.Num25,e.Num24,e.Num23,e.Num22,e.Num21,e.Num20,e.Num19,e.Num18" +
                    " FROM Produtos p, Estoque e WHERE p.ID = e.ProdID AND p.EstaAtivo = 1", conexao);
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
        public DataTable Pesquisar_Produto(string s)
        {
            try
            {
                DataTable dt = new DataTable();
                string server = StringServer();
                conexao = new SqlConnection(server);

                string qr = "SELECT p.Img, p.CodBar, p.QrCode, p.Referencia, p.Nome, p.Modelo, p.Cor," +
                    " p.EstoqueMin, p.PrecoVenda,e.Num44,e.Num43,e.Num42,e.Num41,e.Num40,e.Num39,e.Num38,e.Num37,e.Num36," +
                    " e.Num35,e.Num34,e.Num33,e.Num32,e.Num31,e.Num30,e.Num29, e.Num28,e.Num27,e.Num26,e.Num25,e.Num24,e.Num23," +
                    " e.Num22,e.Num21,e.Num20,e.Num19,e.Num18 FROM Produtos p, Estoque e WHERE ";
                if(s.Length <= 4)
                    qr += "p.Referencia LIKE '%'+@s+'%' ";
                else
                    qr += "p.Codbar LIKE '%'+@s+'%' ";
                qr += " AND p.ID = e.ProdID AND p.EstaAtivo = 1";

                SqlCommand qrComando = new SqlCommand(qr, conexao);
                qrComando.Parameters.AddWithValue("@s", s);
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
        public void Excluir_Produto(string cod)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                string qr = "BEGIN TRANSACTION; UPDATE Produtos SET EstaAtivo = 0 FROM Produtos p, Estoque e WHERE p.CodBar = @cod AND p.ID = e.ProdID; " +
                    "UPDATE Estoque SET Num18 = 0,Num19 = 0,Num20 = 0,Num21 = 0,Num22 = 0,Num23 = 0,Num24 = 0,Num25 = 0,Num26 = 0,Num27 = 0,Num28 = 0," +
                    "Num29 = 0,Num30 = 0,Num31 = 0,Num32 = 0,Num33 = 0,Num34 = 0,Num35 = 0,Num36 = 0,Num37 = 0,Num38 = 0,Num39 = 0,Num40 = 0, " +
                    "Num41 = 0,Num42 = 0,Num43 = 0,Num44 = 0 FROM Produtos p, Estoque e WHERE p.CodBar = @cod AND p.ID = e.ProdID; COMMIT;";
                SqlCommand qrComando = new SqlCommand(qr, conexao);
                qrComando.Parameters.AddWithValue("@cod", cod);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable Carregar_Produto(string id)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                String qr = "SELECT iv.ID, p.CodBar AS 'C. Barras', p.Nome AS 'Produto', iv.Num FROM ItemsVenda iv, Vendas v, Produtos p " +
                    "WHERE v.ID = iv.VendaID AND p.ID = iv.ProdID AND v.ID = @id AND iv.FeitoTroca = 0;";
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

        public int RetornarId(string codbar)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT * FROM Produtos WHERE CodBar = @codbar", conexao);
                qrComando.Parameters.AddWithValue("@codbar", codbar);
                int id = 0;
                conexao.Open();
                SqlDataReader dados = qrComando.ExecuteReader();
                while (dados.Read())
                {
                    id = dados.GetInt32("ID");
                }
                conexao.Close();
                return id;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Fazer_Troca(modeloProduto produto, int codtroca, int codvenda)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);


                string num = "Num" + produto.Num;
                string qr = "BEGIN TRANSACTION; INSERT INTO ItemsVenda(VendaID, ProdID, Num) Values(@codvenda, @prod, @num) ";
                qr += "UPDATE ItemsVenda set FeitoTroca = 1 WHERE ID = @codtroca; ";
                qr += string.Format("UPDATE Estoque SET {0} = {0} - 1 WHERE ProdID = @prod; COMMIT", num);

                SqlCommand qrComando = new SqlCommand(qr, conexao);
                qrComando.Parameters.AddWithValue("@codvenda", codvenda);
                qrComando.Parameters.AddWithValue("@prod", produto.Id);
                qrComando.Parameters.AddWithValue("@num", produto.Num);
                qrComando.Parameters.AddWithValue("@codtroca", codtroca);
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
