using Microsoft.EntityFrameworkCore;
using Model.Model;

namespace DataAccess.Ef.Context
{
    public class GazeteDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Monster;Database=GazeteWeb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Ekonomi> Ekonomies { get; set; }
        public DbSet<Gundem> Gundems { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<OnsozOzel> OnsozOzels { get; set; }
        public DbSet<ResmiIlanlar> ResmiIlanlars { get; set; }
        public DbSet<Spor> Spors { get; set; }
        public DbSet<Yazarlar> Yazarlars { get; set;} 

    }
}
