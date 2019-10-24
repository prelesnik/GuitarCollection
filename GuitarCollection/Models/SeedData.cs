using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GuitarCollection.Data;
using System;
using System.Linq;

namespace GuitarCollection.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new GuitarCollectionContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<GuitarCollectionContext>>()))
			{
				// Look for any movies.
				if (context.Guitar.Any())
				{
					return;   // DB has been seeded
				}

				context.Guitar.AddRange(
					new Guitar
					{
						GuitarType = "Electric",
						GuitarBrand = "Epiphone Les Paul",
						NumStrings = 6,
						StringBrand = "Slinky"
					},

					new Guitar
					{
						GuitarType = "Electric",
						GuitarBrand = "Gibson",
						NumStrings = 6,
						StringBrand = "Slinky"
					},

					new Guitar
					{
						GuitarType = "Electric",
						GuitarBrand = "Agile",
						NumStrings = 7,
						StringBrand = "Slinky"
					},

					new Guitar
					{
						GuitarType = "Bass",
						GuitarBrand = "Ibanez",
						NumStrings = 4,
						StringBrand = "Slinky"
					}
				);
				context.SaveChanges();
			}
		}
	}
}