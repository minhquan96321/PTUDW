using Microsoft.EntityFrameworkCore;
namespace Do_An_PTUDW.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Menu> Menus { get; set; }
    }
}
