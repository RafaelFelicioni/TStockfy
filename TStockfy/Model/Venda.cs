using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Model
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }

        public double TotalValor { get; set; }

        public DateTime DataGravacao { get; set; }

        public string RelatorioVenda { get; set; }

        public Produto Produto { get; set; }

    }
}
