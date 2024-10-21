using GraphQLDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.Data
{
    public class BookDbContext(DbContextOptions<BookDbContext> opts) : DbContext(opts)
    {
        public DbSet<Book> Books { get; set; }
    }
}
