using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuitarCollection.Models;

namespace GuitarCollection.Data
{
    public class GuitarCollectionContext : DbContext
    {
        public GuitarCollectionContext (DbContextOptions<GuitarCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<GuitarCollection.Models.Guitar> Guitar { get; set; }
    }
}
