using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SisLoja
{
    class ClienteDAL
    {
        SqlConnection conexao = null;

        public string StringServer()
        {            
            string server = @"Data Source=Crys-PC;Initial Catalog=SisLoja;User Id=sa;pwd=123;";
            return server;
        }

        public void Gravar_Cliente(modeloCliente cliente)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("INSERT INTO Clientes(Nome,Data,CPF,Rua,Bairro,Cidade,Cep,Estado,Telefone,Whatsapp,Email)" +
                    " VALUES (@Nome,@Data,@CPF,@Rua,@Bairro,@Cidade,@Cep,@Uf,@Fone,@Whatsapp,@Email)", conexao);
                                
                qrComando.Parameters.AddWithValue("@Nome", cliente.Nome);
                qrComando.Parameters.AddWithValue("@Data", cliente.Data);
                qrComando.Parameters.AddWithValue("@CPF", cliente.Cpf);
                qrComando.Parameters.AddWithValue("@Rua", cliente.Rua);
                qrComando.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                qrComando.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                qrComando.Parameters.AddWithValue("@Cep", cliente.Cep);
                qrComando.Parameters.AddWithValue("@Uf", cliente.Uf);
                qrComando.Parameters.AddWithValue("@Fone", cliente.Fone);
                qrComando.Parameters.AddWithValue("@Whatsapp", cliente.Whatsapp);
                qrComando.Parameters.AddWithValue("@Email", cliente.Email);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        public DataTable Listar_Clientes() 
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("SELECT ID, Nome, CPF, Telefone, Whatsapp, Email, Cep, Rua, Bairro," +
                    " Cidade, Estado FROM Clientes WHERE EstaAtivo = 1", conexao);
                SqlDataAdapter dados = new SqlDataAdapter();
                DataTable dt = new DataTable();
                dados.SelectCommand = qrComando;
                dados.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }            
        }

        public void Excluir_Cliente(modeloCliente cliente) 
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("UPDATE Clientes SET EstaAtivo = 0 WHERE ID= @id", conexao);
                qrComando.Parameters.AddWithValue("@id", cliente.Id);
                conexao.Open();
                qrComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar_Cliente(modeloCliente cliente)
        {
            try
            {
                string server = StringServer();
                conexao = new SqlConnection(server);
                SqlCommand qrComando = new SqlCommand("UPDATE Clientes SET Nome = @nome, CPF = @cpf, Rua = @rua, " +
                    "Bairro = @bairro, Cidade = @cidade, Estado = @uf, Telefone = @fone, Whatsapp = @whats," +
                    " Email = @email WHERE ID = @id", conexao);
                qrComando.Parameters.AddWithValue("@id", cliente.Id);
                qrComando.Parameters.AddWithValue("@nome", cliente.Nome);
                qrComando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                qrComando.Parameters.AddWithValue("@fone", cliente.Fone);
                qrComando.Parameters.AddWithValue("@whats", cliente.Whatsapp);
                qrComando.Parameters.AddWithValue("@email", cliente.Email);
                qrComando.Parameters.AddWithValue("@cep", cliente.Cep);
                qrComando.Parameters.AddWithValue("@rua", cliente.Rua);
                qrComando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                qrComando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                qrComando.Parameters.AddWithValue("@uf", cliente.Uf);
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
