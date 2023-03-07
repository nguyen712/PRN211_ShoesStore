using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRN211_ShoesStore.Models;
using PRN211_ShoesStore.Models.Entity;

namespace PRN211_ShoesStore.Views.ViewShoes
{
    public class EditModel : PageModel
    {
        private readonly PRN211_ShoesStore.Models.AppDbContext _context;

        public EditModel(PRN211_ShoesStore.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Shoes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoesExists(Shoes.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShoesExists(int id)
        {
            return _context.shoes.Any(e => e.id == id);
        }
    }
}
