using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Model
{
    public class Produto {
        [Key]
        public int IdProduto { get; set; }

        [StringLength(50)]
        public string NomeProduto { get; set; }

        [StringLength(50)]
        public string ValorProduto { get; set; }

        [StringLength(50)]
        public string CdgBarras { get; set; }

        [StringLength(50)] 
        public string QntEstoque { get; set; }

        [StringLength(50)]
        public string LclNoEstoque { get; set; }

        [StringLength(50)]
        public string NmrNota { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }
    }
}
