using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dirarys_Final_Project.Models;

namespace Dirarys_Final_Project.Pages.Characters
{
    // Page model for delete page.
    public class DeleteModel : PageModel
    {
        private readonly Dirarys_Final_Project.Models.CharacterDbContext _context; // Replaces "db" variable
        // Give model access to database.
        public DeleteModel(Dirarys_Final_Project.Models.CharacterDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // Find character to delete.
            Character = await _context.Characters.FindAsync(id);

            if (Character != null)
            {
                // Delete character and save database changes.
                _context.Characters.Remove(Character);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
