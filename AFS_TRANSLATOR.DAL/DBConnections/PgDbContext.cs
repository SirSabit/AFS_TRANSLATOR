using AFS_TRANSLATOR.ENTITIES;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DAL.DBConnections
{
    public class PgDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TranslatorDb;User Id=postgres;Password=postgres;");
        }
        public DbSet<RequestResponseLog> RequestResponseLogs { get; set; }        
    }
}
