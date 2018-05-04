using System.Data.Entity;
using HomeControlServer.Models;

namespace HomeControlServer.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }

        public DbSet<Plug> Plugs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}