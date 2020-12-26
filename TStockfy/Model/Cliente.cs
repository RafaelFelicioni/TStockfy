using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Model
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public int CPF { get; set; }

        [StringLength(50)]
        public string CNPJ { get; set; }

        
        
        public virtual Endereco Endereco { get; set; }
    }
}
