using Microsoft.EntityFrameworkCore;
    
namespace brightideas.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options) {}
        public DbSet<User> user { get; set; }
        public DbSet<Idea> idea { get; set; }
        public DbSet<Like> like{get;set;}

    }
}