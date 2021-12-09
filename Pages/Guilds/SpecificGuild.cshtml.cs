using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dirarys_Final_Project.Models;

namespace Dirarys_Final_Project.Pages.Guilds
{
    public class SpecificGuildModel : PageModel
    {
        private readonly Dirarys_Final_Project.Models.CharacterDbContext _context;

        public SpecificGuildModel(Dirarys_Final_Project.Models.CharacterDbContext context)
        {
            _context = context;
        }

        public Guild Guild { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guild = await _context.Guilds
                .Include(c => c.Characters)
                .FirstOrDefaultAsync(c => c.GuildID == id);

            if (Guild == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}