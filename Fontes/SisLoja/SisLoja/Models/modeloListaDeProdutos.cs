﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    public class modeloListaDeProdutos
    {
        public Image Img { get; set; }
        public string Nome { get; set;}
        public int Qtd { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
