using Mon_Petit_Sucre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Entities
{
    public class VendaEntity : GenericEntity<Venda>
    {
        public VendaEntity() : base(new Contexts.GenericContext())
        {

        }
    }
}
