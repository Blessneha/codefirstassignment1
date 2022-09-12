using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirstApproach1.Entities
{
    internal class assign2Context:DbContext
    {
        public assign2Context():base("name=assign2Connection")
        {

        }

        public DbSet<Movie> Movies { get; set; }


    }
}
