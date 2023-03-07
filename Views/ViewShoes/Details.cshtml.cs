using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PRN211_ShoesStore.Models;
using PRN211_ShoesStore.Models.Entity;

namespace PRN211_ShoesStore.Views.ViewShoes
{
    public class DetailsModel : PageModel
    {
        private readonly PRN211_ShoesStore.Models.AppDbContext _context;

        public DetailsModel(PRN211_ShoesStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public Shoes Shoes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shoes = await _context.shoes.FirstOrDefaultAsync(m => m.id == id);

            if (Shoes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
