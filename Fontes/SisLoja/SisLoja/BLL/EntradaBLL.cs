using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SisLoja
{
    public class EntradaBLL
    {
        EntradaDAL DAL = new EntradaDAL();

        // ------ Validações ------- //

        private static bool Check_Int(string input)
        {
            if (int.TryParse(input, out int value))
                return true;
            return false;
        }

        private static bool Check_Decimal(string input)
        {
            if (Decimal.TryParse(input, out decimal value))
                return true;
            return false;
        }


        private string Somar(string s)
        {
            int resultado = 0;
            string[] texto = s.Split(',');
            for (int i = 0; i < texto.Length; i++)
            {
                resultado = resultado + Convert.ToInt32(texto[i].Substring(texto[i].LastIndexOf(':') + 1));
            }
            return resultado.ToString();
        }

        public modeloProduto Buscar_ProdutoDAL(string s) 
        {            
            modeloProduto produto = DAL.Buscar_Produto(s);
            return produto;
        }

        public int Gravar_EntradaDAL(modeloEntrada entrada, string valor)
        {
            //    if (Check_Decimal(valor) == false)
            //        return 1;
            //    else
            //        entrada.Valor = Convert.ToDecimal(valor);

            if (entrada.Qtd == "" | entrada.Valor == 0)
            {
                return 1;
            }

            if (DAL.Gravar_Entrada(entrada) == 0)
            {
                DAL.Atualizar_Estoque(entrada);
                return 0;
            }
            return 1;
        }
    }
}
