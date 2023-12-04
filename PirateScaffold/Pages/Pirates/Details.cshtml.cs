using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PirateScaffold.Models;

namespace PirateScaffold.Pages.Pirates
{
    public class DetailsModel : PageModel
    {
        private readonly PirateScaffold.Models.PirateContext _context;

        public DetailsModel(PirateScaffold.Models.PirateContext context)
        {
            _context = context;
        }

      public Pirate Pirate { get; set; } = default!; 

      [BindProperty]
      public int PirateCrewIDToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pirates == null)
            {
                return NotFound();
            }

            var pirate = await _context.Pirates.Include(c => c.PirateCrews).FirstOrDefaultAsync(m => m.PirateID == id);
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
        public IActionResult OnPostDeletePirateCrew(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Find the Crew in the database
            var PirateCrew = _context.PirateCrews.FirstOrDefault(r => r.PirateCrewID == PirateCrewIDToDelete);
            
            if (PirateCrew != null)
            {
                _context.Remove(PirateCrew); // Delete the review
                _context.SaveChanges();
            }

            Pirate = _context.Pirates.Include(p => p.PirateCrews).First(p => p.PirateID == id);

            return Page();
        }   
    }
}