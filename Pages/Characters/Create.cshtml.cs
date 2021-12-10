using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dirarys_Final_Project.Models;

namespace Dirarys_Final_Project.Pages.Characters
{
    // Page model for create page.
    public class CreateModel : PageModel
    {
        private readonly Dirarys_Final_Project.Models.CharacterDbContext _context; // Replaces "db" variable
        // Give model access to database.
        public CreateModel(Dirarys_Final_Project.Models.CharacterDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        // Lets user choose guild and land for new character.
        ViewData["GuildID"] = new SelectList(_context.Guilds, "GuildID", "Name");
        ViewData["LandID"] = new SelectList(_context.LandOfOrigins, "LandOfOriginID", "Name");
            return Page();
        }

        [BindProperty]
        public Character Character { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Add new character to database and save.
            _context.Characters.Add(Character);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
