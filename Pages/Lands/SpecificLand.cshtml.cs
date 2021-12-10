using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dirarys_Final_Project.Models;

namespace Dirarys_Final_Project.Pages.Lands
{
    // Page model for specific land page.
    public class SpecificLandModel : PageModel
    {
        private readonly Dirarys_Final_Project.Models.CharacterDbContext _context;
        // Give model access to database.
        public SpecificLandModel(Dirarys_Final_Project.Models.CharacterDbContext context)
        {
            _context = context;
        }

        public LandOfOrigin Land { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // Finds the selected land of origin and all characters belonging to that land.
            Land = await _context.LandOfOrigins
                .Include(c => c.Characters)
                .FirstOrDefaultAsync(c => c.LandOfOriginID == id);

            if (Land == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}