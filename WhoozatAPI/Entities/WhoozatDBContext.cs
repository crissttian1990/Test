using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoozatAPI.Entities
{
    public class WhoozatDBContext : DbContext
    {

        public WhoozatDBContext(DbContextOptions<WhoozatDBContext> options) : base(options)
        {

        }

        public DbSet<Estate> Estates { get; set; }

    }
}
