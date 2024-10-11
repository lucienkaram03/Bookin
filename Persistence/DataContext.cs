
using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) //constructor
        {
        }

        public DbSet<Book> Books {get ; set ; } 
    }
}