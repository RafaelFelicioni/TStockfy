using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Model
{
    public class Acesso
    {
        [Key]
        public int AcessoId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Senha { get; set; }

        //public object Role { get; internal set; }

    }
}
