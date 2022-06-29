using AFS_TRANSLATOR.ENTITIES;
using Microsoft.EntityFrameworkCore;

namespace AFS_TRANSLATOR.DAL.DBConnections
{
    public class PgDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=AfsTranslatorDb;User Id=postgres;Password=postgres;");
        }
        public DbSet<TranslationHistory> Translations { get; set; }
    }
}
