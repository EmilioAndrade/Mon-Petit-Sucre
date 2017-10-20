using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Contexts
{
    public class GenericContext : DbContext
    {
        //construtor passando a connection string para a classe mãe DbContext (base)
        public GenericContext(string connectionString) : base(connectionString)
        {

        }
        //valor padrão da connection string
        public GenericContext() : this("MonPetitSucre")
        {

        }
    }
}
