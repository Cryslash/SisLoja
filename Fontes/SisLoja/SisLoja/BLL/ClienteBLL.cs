using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SisLoja
{
    class ClienteBLL
    {
        public DataTable Listar_ClientesDAL()
        {            
            ClienteDAL clienteDal = new ClienteDAL();
            DataTable dt = clienteDal.Listar_Clientes();
            return dt;
        }

        public DataTable Pesquisar_ClienteDAL(string s)
        {
            DataTable dt = new DataTable();
            ClienteDAL clienteDAL = new ClienteDAL();
            dt = clienteDAL.Pesquisar_Cliente(s);
            return dt;
        }
        
        public int Gravar_ClienteDAL(modeloCliente cliente)
        {
            //código 0 = sucesso
            //código 1 = campos obrigatórios em branco
            int isnumber, code = 0;

            if (cliente.Nome == String.Empty | cliente.Fone == String.Empty)
              code=1;         
            
            if (code >= 1)
              return code;
            
            ClienteDAL Dados = new ClienteDAL();
            Dados.Gravar_Cliente(cliente);
            return code;
        }

        public void Atualizar_ClienteDAL(modeloCliente cliente)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.Atualizar_Cliente(cliente);
        }

        public void Excluir_ClienteDAL(modeloCliente cliente)
        {
            ClienteDAL clienteDal = new ClienteDAL();
            clienteDal.Excluir_Cliente(cliente);
        }

    }
}
