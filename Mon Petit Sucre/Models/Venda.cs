using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Models
{
    public class Venda : GenericModel
    {
        [Key]
        public long IdVenda { get; set; }

        public long IdProduto { get; set; }

        public DateTime DataVenda { get; set; }

        public decimal ValorVenda { get; set; }

        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }
    }
}
