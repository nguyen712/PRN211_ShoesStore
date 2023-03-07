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
    public class IndexModel : PageModel
    {
        private readonly PRN211_ShoesStore.Models.AppDbContext _context;

        public IndexModel(PRN211_ShoesStore.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Shoes> Shoes { get;set; }

        public async Task OnGetAsync()
        {
            Shoes = await _context.shoes.ToListAsync();
        }
    }
}
