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
                SqlCommand qrComando = new SqlCommand("SELECT * FROM Clientes WHERE EstaAtivo = 1", conexao);
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

    }
}
