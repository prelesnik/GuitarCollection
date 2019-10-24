using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GuitarCollection.Data;
using GuitarCollection.Models;

namespace GuitarCollection.Pages.Guitars
{
    public class CreateModel : PageModel
    {
        private readonly GuitarCollection.Data.GuitarCollectionContext _context;

        public CreateModel(GuitarCollection.Data.GuitarCollectionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Guitar Guitar { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Guitar.Add(Guitar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
