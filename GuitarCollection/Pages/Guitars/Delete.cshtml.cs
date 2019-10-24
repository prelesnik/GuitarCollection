using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GuitarCollection.Data;
using GuitarCollection.Models;

namespace GuitarCollection.Pages.Guitars
{
    public class DeleteModel : PageModel
    {
        private readonly GuitarCollection.Data.GuitarCollectionContext _context;

        public DeleteModel(GuitarCollection.Data.GuitarCollectionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Guitar Guitar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guitar = await _context.Guitar.FirstOrDefaultAsync(m => m.ID == id);

            if (Guitar == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guitar = await _context.Guitar.FindAsync(id);

            if (Guitar != null)
            {
                _context.Guitar.Remove(Guitar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
