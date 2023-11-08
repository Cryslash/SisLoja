using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    public class modeloProduto
    {
        int id, estoque, estoquemin;
        string codbar, qrcode, referencia, img, nome, modelo, cor;
        decimal precoVenda;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        public int EstoqueMin
        {
            get { return estoquemin; }
            set { estoquemin = value; }
        }

        public string CodBar
        {
            get { return codbar; }
            set { codbar = value; }
        }
        public string QrCode
        {
            get { return qrcode; }
            set { qrcode = value; }
        }
        public string Ref
        {
            get { return referencia; }
            set { referencia = value; }
        }
        public string Img
        {
            get { return img; }
            set { img = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public decimal PrecoVenda 
        { 
            get { return precoVenda; }
            set { precoVenda = value; }
        }
    }
}
