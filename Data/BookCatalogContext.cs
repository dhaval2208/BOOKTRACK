using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrack.Model;

namespace BookCatelog.Data
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext (DbContextOptions<BookCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<BookTrack.Model.Book> Book { get; set; } = default!;
    }
}
