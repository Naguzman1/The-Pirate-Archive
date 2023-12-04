using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PirateScaffold.Models;

namespace PirateScaffold.Pages.Pirates
{
    public class EditModel : PageModel
    {
        private readonly PirateScaffold.Models.PirateContext _context;

        public EditModel(PirateScaffold.Models.PirateContext context)
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

            var pirate =  await _context.Pirates.FirstOrDefaultAsync(m => m.PirateID == id);
            if (pirate == null)
            {
                return NotFound();
            }
            Pirate = pirate;
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

            _context.Attach(Pirate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PirateExists(Pirate.PirateID))
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

        private bool PirateExists(int id)
        {
          return (_context.Pirates?.Any(e => e.PirateID == id)).GetValueOrDefault();
        }
    }
}
