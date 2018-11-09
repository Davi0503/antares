using System;
using System.Collections.Generic;

namespace Antares.vendas.ViewModels {
    public class VendasViewModels {
        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public List<ProdutoViewModels> Produtos { get; set; }
        public double Total { get; set; }
        public DateTime DataVenda { get; set; }

    }
}