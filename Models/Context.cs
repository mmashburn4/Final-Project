using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models{
    public class Context : DbContext{
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Artist> Artists {get; set;}
        public DbSet<RecordLabel> RecordLabels {get; set;}
    }
}