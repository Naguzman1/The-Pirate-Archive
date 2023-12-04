using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PirateScaffold.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PirateScaffold.Pages.Pirates
{
    public class AddPirateCrewModel : PageModel
    {
        private readonly ILogger<AddPirateCrewModel> _logger;
        private readonly PirateContext _context;
        [BindProperty]
        public PirateCrew PirateCrew {get; set;} = default!;
        public SelectList PiratesDropDown {get; set;} = default!;

        public AddPirateCrewModel(PirateContext context, ILogger<AddPirateCrewModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            PiratesDropDown = new SelectList(_context.Pirates.ToList(), "PirateID", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PirateCrews.Add(PirateCrew);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}