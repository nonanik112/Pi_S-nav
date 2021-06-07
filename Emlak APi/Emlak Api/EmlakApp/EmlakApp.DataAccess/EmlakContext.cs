using EmlakApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmlakApp.DataAccess
{
    public class EmlakContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<Ev> Evler { get; set; }
    }
}