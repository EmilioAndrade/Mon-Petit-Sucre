using Mon_Petit_Sucre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Entities
{
    public class IngredienteEntity : GenericEntity<Ingrediente>
    {
        public IngredienteEntity() : base (new Contexts.GenericContext())
        {

        }
    }
}
