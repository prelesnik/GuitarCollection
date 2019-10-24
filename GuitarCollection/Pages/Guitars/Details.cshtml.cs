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
    public class DetailsModel : PageModel
    {
        private readonly GuitarCollection.Data.GuitarCollectionContext _context;

        public DetailsModel(GuitarCollection.Data.GuitarCollectionContext context)
        {
            _context = context;
        }

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
    }
}
