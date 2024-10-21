using GraphQLDemo.Data;
using GraphQLDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.GraphQL
{
    public class Mutation
    {
        public async Task<Book> AddBook([Service] BookDbContext ctx, string title, string author)
        {
            var book = new Book { Title = title, Author = author };
            ctx.Books.Add(book);
            await ctx.SaveChangesAsync();
            return book;
        }
    }
}
