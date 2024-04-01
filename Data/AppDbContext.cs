using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class AppDbContext : DbContext
    {

        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=MyPassword123#");
        }
    }
}

