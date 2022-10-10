using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InventoryOfBookCollection.Data;
using InventoryOfBookCollection.Models;

namespace InventoryOfBookCollection.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly InventoryOfBookCollection.Data.InventoryOfBookCollectionContext _context;

        public CreateModel(InventoryOfBookCollection.Data.InventoryOfBookCollectionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
