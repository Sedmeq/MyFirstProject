using Microsoft.EntityFrameworkCore;

namespace MyFirstProject.Models
{
    public class MyFirstProjectDbContext : DbContext
    {

        public MyFirstProjectDbContext(DbContextOptions<MyFirstProjectDbContext> options)
            :base(options)
        {
        }
        public DbSet<Expense> Expenses { get; set; }

    }
}
