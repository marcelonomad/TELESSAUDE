using Microsoft.EntityFrameworkCore;
using TelessaudeData.Models;

namespace TelessaudeData.Contexts
{
    public class TelessaudeContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public TelessaudeContext(DbContextOptions<TelessaudeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paciente>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Telefone>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6MCOOR6\\SQLEXPRESS;Database=BD_TELESSAUDE;User Id=sa;Password=123456;");
        }
    }
}
