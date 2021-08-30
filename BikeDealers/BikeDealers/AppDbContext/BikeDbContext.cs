using BikeDealers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDealers.AppDbContext
{
    public class BikeDbContext:DbContext
    {
        /*
        Reference Links
        https://entityframeworkcore.com/knowledge-base/49736557/implementing-dbcontextoptions
        https://www.tektutorialshub.com/entity-framework-core/ef-core-dbcontext/
        */
        public BikeDbContext(DbContextOptions<BikeDbContext> options) : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models{ get; set; }
    }
}
