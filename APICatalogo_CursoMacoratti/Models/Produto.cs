﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo_CursoMacoratti.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }    
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
