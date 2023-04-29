using Microsoft.EntityFrameworkCore;
namespace P2_2019CG606.Models
{
    public class registroCovidContext : DbContext
    {
        public registroCovidContext(DbContextOptions options) : base(options) { 

        }
        public DbSet<departamentos> departamentos { get; set;}
        public DbSet<generos> generos { get; set;}
        public DbSet<casos_reportado> casos_reportado { get;set;}
    }
}
