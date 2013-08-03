using System.Data.Entity;

namespace QAForum.Models
{
    public class ForumEntities : DbContext
    {
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forum>().ToTable("Forums");
            modelBuilder.Entity<User>().ToTable("aspnet_Users");
        }
    }
}