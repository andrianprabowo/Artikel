
using Artikel.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Artikel.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Content> Contents { get; set; } 
        public DbSet<Photo> Photos { get; set; }
    }
}