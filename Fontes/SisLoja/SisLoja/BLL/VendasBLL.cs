﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    internal class VendasBLL
    {
        VendasDAL DAL = new VendasDAL();
        public modeloProduto BuscarProdutoDAL(string codbar)
        {
            modeloProduto produto = DAL.Buscar_Produto(codbar);
            return produto;
        }
        public int Proximo_ID_VendaDAL()
        {
            return DAL.Proximo_ID_Venda();
        }
        public DataTable PesquisarClienteDAL(string s)
        {
            DataTable dt = DAL.PesquisarCliente(s);
            return dt;
        }
        public bool Numero_DisponivelDAL(string codbar, int num, int qtd)
        {
            return DAL.Numero_Disponivel(codbar, num, qtd);
        }
    }
}
