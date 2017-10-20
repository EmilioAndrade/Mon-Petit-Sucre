using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Models
{
    public class Ingrediente : GenericModel
    {
        [Key]
        public long IdIngrediente { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataCompra { get; set; }
    }
}
