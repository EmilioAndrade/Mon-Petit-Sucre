using Mon_Petit_Sucre.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Petit_Sucre.Contexts
{
    public class MonPetitSucreContext
    {
        public MonPetitSucreContext()
        {

        }

        //Tabelas do BD
        public DbSet<Ingrediente> Igrediente;

        public DbSet<Produto> Produto;

        public DbSet<Venda> Venda;
    }
}
