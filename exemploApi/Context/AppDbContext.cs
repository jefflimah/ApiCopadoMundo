
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploApi.Context
{
	public class AppDbContext : DbContext
	{
        

        public AppDbContext()
        { }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        
        public virtual DbSet<participante> participante { get; set; }
        public virtual DbSet<confederacao> confederacao { get; set; }
        public virtual DbSet<Pote> Pote { get; set; }
        public virtual DbSet<PoteParticipante> PoteParticipante { get; set; }
        public virtual DbSet<grupo> grupo { get; set; }
        public virtual DbSet<grupoParticipante> grupoParticipante { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
