using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Dirarys_Final_Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dirarys_Final_Project.Pages.Lands
{
    // Page model for land page.
    public class LandModel : PageModel
    {
        private readonly CharacterDbContext _context; // Replaces "db" variable
        private readonly ILogger<IndexModel> _logger;
        public List<LandOfOrigin> Lands {get; set;}
        // Give model access to database.
        public LandModel(CharacterDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            // Gathers lands from database and creates a list.
            Lands = _context.LandOfOrigins.ToList();
        }
    }
}