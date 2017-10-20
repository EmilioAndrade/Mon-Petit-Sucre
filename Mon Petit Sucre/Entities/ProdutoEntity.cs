using Mon_Petit_Sucre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Entities
{
    public class ProdutoEntity : GenericEntity<Produto>
    {
        public ProdutoEntity() : base (new Contexts.GenericContext())
        {

        }
    }
}
