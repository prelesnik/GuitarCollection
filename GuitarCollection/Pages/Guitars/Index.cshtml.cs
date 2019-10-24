using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GuitarCollection.Data;
using GuitarCollection.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GuitarCollection.Pages.Guitars
{
    public class IndexModel : PageModel
    {
        private readonly GuitarCollection.Data.GuitarCollectionContext _context;

        public IndexModel(GuitarCollection.Data.GuitarCollectionContext context)
        {
            _context = context;
        }

        public IList<Guitar> Guitar { get;set; }
		[BindProperty(SupportsGet = true)]
		public string SearchString { get; set; }
		// Requires using Microsoft.AspNetCore.Mvc.Rendering;
		public SelectList GuitarBrands { get; set; }
		[BindProperty(SupportsGet = true)]
		public string GuitarGuitarBrand { get; set; }

		public async Task OnGetAsync()
        {
			IQueryable<string> brandQuery = from m in _context.Guitar
											orderby m.GuitarBrand
											select m.GuitarBrand;

			var guitars = from m in _context.Guitar
						 select m;

			if (!string.IsNullOrEmpty(SearchString))
			{
				guitars = guitars.Where(s => s.GuitarType.Contains(SearchString));
			}

			if (!string.IsNullOrEmpty(GuitarGuitarBrand))
			{
				guitars = guitars.Where(x => x.GuitarBrand == GuitarGuitarBrand);
			}
			GuitarBrands = new SelectList(await brandQuery.Distinct().ToListAsync());
			Guitar = await guitars.ToListAsync();
		}
    }
}
