using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRN211_ShoesStore.Models;
using PRN211_ShoesStore.Models.Entity;

namespace PRN211_ShoesStore.Views.ViewShoes
{
    public class CreateModel : PageModel
    {
        private readonly PRN211_ShoesStore.Models.AppDbContext _context;

        public CreateModel(PRN211_ShoesStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Shoes Shoes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.shoes.Add(Shoes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
