using Microsoft.EntityFrameworkCore;
using WebAppServer.Models;

namespace WebAppServer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Server> Servers { get; set; } = null!;
        public DbSet<ServerModel> ServersModels { get; set; } = null!;
        public DbSet<OS> Oss {  get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=serversDB.db");
        }

    }
}
