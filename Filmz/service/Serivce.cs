using Filmz.bd;
using Microsoft.EntityFrameworkCore;

namespace Filmz.service
{
    internal class Serivce : DbContext 
    {
        public DbSet<Film> Films { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=../../../databse.db");
        }
    }
}
