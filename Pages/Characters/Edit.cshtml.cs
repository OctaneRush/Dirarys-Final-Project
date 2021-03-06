using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dirarys_Final_Project.Models;

namespace Dirarys_Final_Project.Pages.Characters
{
    // Page model for edit page.
    public class EditModel : PageModel
    {
        private readonly Dirarys_Final_Project.Models.CharacterDbContext _context; // Replaces "db" variable
        // Give model access to database.
        public EditModel(Dirarys_Final_Project.Models.CharacterDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // Finds selected character and includes guild and land.
            Character = await _context.Characters
                .Include(c => c.Guild)
                .Include(c => c.Land).FirstOrDefaultAsync(m => m.CharacterID == id);

            if (Character == null)
            {
                return NotFound();
            }
            // Lets user choose which guild or land to changed to.
           ViewData["GuildID"] = new SelectList(_context.Guilds, "GuildID", "Name");
           ViewData["LandID"] = new SelectList(_context.LandOfOrigins, "LandOfOriginID", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // Changes edited character in database.
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(Character.CharacterID))
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
        // Returns original character if the character was not edited.
        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.CharacterID == id);
        }
    }
}
