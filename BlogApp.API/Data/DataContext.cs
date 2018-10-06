using BlogApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> option):base(option)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}