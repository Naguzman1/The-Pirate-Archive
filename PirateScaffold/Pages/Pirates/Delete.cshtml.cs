using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PirateScaffold.Models;

namespace PirateScaffold.Pages.Pirates
{
    public class DeleteModel : PageModel
    {
        private readonly PirateScaffold.Models.PirateContext _context;

        public DeleteModel(PirateScaffold.Models.PirateContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Pirate Pirate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pirates == null)
            {
                return NotFound();
            }

            var pirate = await _context.Pirates.FirstOrDefaultAsync(m => m.PirateID == id);

            if (pirate == null)
            {
                return NotFound();
            }
            else 
            {
                Pirate = pirate;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pirates == null)
            {
                return NotFound();
            }
            var pirate = await _context.Pirates.FindAsync(id);

            if (pirate != null)
            {
                Pirate = pirate;
                _context.Pirates.Remove(Pirate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
