using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Models
{
    public class Ingrediente
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataCompra { get; set; }
    }
}
