using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryOfBookCollection.Data;
using InventoryOfBookCollection.Models;

namespace InventoryOfBookCollection.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryOfBookCollection.Data.InventoryOfBookCollectionContext _context;

        public DetailsModel(InventoryOfBookCollection.Data.InventoryOfBookCollectionContext context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.AuthorId == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
