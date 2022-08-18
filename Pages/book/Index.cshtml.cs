using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCatelog.Data;
using BookTrack.Model;

namespace BookTrack.Pages.book
{
    public class IndexModel : PageModel
    {
        private readonly BookCatelog.Data.BookCatalogContext _context;

        public IndexModel(BookCatelog.Data.BookCatalogContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
