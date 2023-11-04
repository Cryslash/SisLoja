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
        public int Gravar_ClienteDAL(modeloCliente cliente)
        {
            //código 0 = sucesso
            //código 1 = erro na validação
            //código 2 = campos obrigatórios em branco
            int isnumber, code = 0;

            if (!int.TryParse(cliente.Cpf.ToString(), out isnumber))
            {
                if (cliente.Cpf != string.Empty)
              code = 1;
            }
            if (!int.TryParse(cliente.Fone.ToString(), out isnumber))
            {
                if (cliente.Fone != string.Empty)
                    code = 1;
            }
            if (!int.TryParse(cliente.Whatsapp.ToString(), out isnumber))
            {
                if (cliente.Whatsapp != string.Empty)
                    code = 1;
            }
            if (!int.TryParse(cliente.Cep.ToString(), out isnumber))
            {
                if (cliente.Cep != string.Empty)
                    code = 1;
            }
            //  int code = !int.TryParse(cliente.Cpf.ToString(), out isnumber) | !int.TryParse(cliente.Fone.ToString(), out isnumber) |
            //      !int.TryParse(cliente.Whatsapp.ToString(), out isnumber) | !int.TryParse(cliente.Cep.ToString(), out isnumber) ? 1 : 0;

            if (cliente.Nome == String.Empty | cliente.Fone == String.Empty)
              code=2;         
            
            if (code >= 1)
              return code;
            
            ClienteDAL Dados = new ClienteDAL();
            Dados.Gravar_Cliente(cliente);
            return code;
        }

        public DataTable Listar_ClientesDAL()
        {            
            ClienteDAL clienteDal = new ClienteDAL();
            DataTable dt = clienteDal.Listar_Clientes();
            return dt;
        }

    }
}
