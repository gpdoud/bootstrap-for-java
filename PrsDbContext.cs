using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaWebApi.Models {
    public class PrsDbContext : DbContext {

        public PrsDbContext(DbContextOptions<PrsDbContext> options ) : base(options) {

        }

        public DbSet<Vendor> Vendors { get; set; }
    }
}
