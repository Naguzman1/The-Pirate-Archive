using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PirateScaffold.Models;

namespace PirateScaffold.Pages.Pirates
{
    public class CreateModel : PageModel
    {
        private readonly PirateScaffold.Models.PirateContext _context;

        public CreateModel(PirateScaffold.Models.PirateContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pirate Pirate { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pirates == null || Pirate == null)
            {
                return Page();
            }

            _context.Pirates.Add(Pirate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
