using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebRazorPages.Pages
{
    public class MinhaModel : PageModel
    {
        private readonly AppDbContext _db;

        public List<Animal> Anis { get; set; }

        [BindProperty]
        public Animal Animal { get; set; }

        [TempData]
        public string Info { get; set; }

        public MinhaModel(AppDbContext db)
        {
            _db = db;
        }

        public async Task OnGet()
        {
            Anis = await _db.Animals.AsNoTracking().ToListAsync();
        }


        
        public async Task<IActionResult> OnPostAsync()
        {

            _db.Animals.Add(Animal);
            await _db.SaveChangesAsync();

            Info = $"Animal {Animal.Name} add with success";

            return RedirectToPage("/Minha");

        }



    }
}