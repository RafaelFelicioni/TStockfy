using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Model
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [StringLength(100)]
        public string Logradouro { get; set; }

        [StringLength(100)]
        public string Bairro { get; set; }

        [StringLength(100)]
        public string Cidade { get; set; }

        [StringLength(100)]
        public string Estado { get; set; }

        [StringLength(20)]
        public string Cep { get; set; }
    }
}
