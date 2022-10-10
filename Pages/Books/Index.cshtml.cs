using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryOfBookCollection.Data;
using InventoryOfBookCollection.Models;

namespace InventoryOfBookCollection.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly InventoryOfBookCollection.Data.InventoryOfBookCollectionContext _context;

        public IndexModel(InventoryOfBookCollection.Data.InventoryOfBookCollectionContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                .Include(b => b.Author).ToListAsync();
            }
        }
    }
}
