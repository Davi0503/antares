using System;
using System.Collections.Generic;

namespace Antares.vendas.ViewModels {
    public class ComprasViewModels {

        public int Id { get; set; }

        public List<ProdutoViewModels> Produtos { get; set; }

        public double TotalPreco { get; set; }

        public DateTime DataCompra { get; set; }

    }
}