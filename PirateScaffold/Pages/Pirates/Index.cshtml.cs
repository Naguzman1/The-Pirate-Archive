using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PirateScaffold.Models;
using SQLitePCL;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PirateScaffold.Pages.Pirates
{
    public class IndexModel : PageModel
    {
        private readonly PirateScaffold.Models.PirateContext _context;

        public IndexModel(PirateScaffold.Models.PirateContext context)
        {
            _context = context;
        }

        public IList<Pirate> Pirate { get;set; } = default!;
        
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;


        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
             var query = _context.Pirates.Select(p => p);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(p => p.Name);
                    break;

                case "first_desc":
                    query = query.OrderByDescending(p => p.Name);
                    break;
            }





            if (_context.Pirates != null)
            {
                Pirate = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }

        
        }
    }
}
