﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.pt.projeto.model
{
    public class Itensvendas
    {
        public int venda_id { get; set; }
        public int produto_id { get; set; }
        public int qtd { get; set; }
        public decimal subtotal { get; set; }
    }
}
