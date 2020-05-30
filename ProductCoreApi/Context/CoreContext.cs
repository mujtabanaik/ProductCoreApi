using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCoreApi.Models;

namespace ProductCoreApi.Context
{
    public class CoreContext: DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:mujtabactl.database.windows.net,1433;Initial Catalog=test_db;Persist Security Info=False;User ID=mujtaba;Password=Ayaz@1988;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<ProductCoreApi.Models.Product> Product { get; set; }
    }
}
