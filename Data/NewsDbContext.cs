using AsyncWebScraper.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncWebScraper.Data
{
    internal class NewsDbContext : DbContext
    {
        public DbSet<NewsItem> NewsItems { get; set; }
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options) { }
    }
}
