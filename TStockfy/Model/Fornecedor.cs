using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Model
{
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }

        [StringLength(50)]
        public string NomeEmpresa { get; set; }

        [StringLength(50)]
        public string CNPJ { get; set; }

        [StringLength(50)]
        public string Endereco { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }


    }
}
