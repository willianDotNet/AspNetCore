using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteRazor.Pages
{
    public class MinhaPaginaModel : PageModel
    {
        [BindProperty]
        public Animal Ani { get; set; }

        public List<Animal> ListaAnimals { get; set; }

        private readonly MyAppDbContext _context;

        public MinhaPaginaModel(MyAppDbContext ctc)
        {
            _context = ctc;
        }

        public void OnGet()
        {
            ListaAnimals = _context.Animals.ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            _context.Animals.Add(Ani);
            await _context.SaveChangesAsync();

            return RedirectToAction("/MinhaPagina");

        }
    }
}