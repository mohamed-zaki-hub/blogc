using Microsoft.EntityFrameworkCore;

namespace src.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options): base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUS> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Teammembers> Teammembers { get; set; }

    }
}
