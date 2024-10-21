using GraphQLDemo.Data;
using GraphQLDemo.Models;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.GraphQL
{
    public class Query
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Book> GetBooks([Service] BookDbContext ctx)
        {
            return ctx.Books;
        }
    }
}
