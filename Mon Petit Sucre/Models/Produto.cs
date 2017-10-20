using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Models
{
    public class Produto : GenericModel
    {
        [Key]
        public long IdProduto { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Status { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
