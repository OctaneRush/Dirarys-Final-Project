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

namespace Dirarys_Final_Project.Pages.Characters
{
    public class CharacterModel : PageModel
    {
        private readonly CharacterDbContext _context; // Replaces "db" variable
        private readonly ILogger<IndexModel> _logger;
        public List<Character> Characters {get; set;}
        // public SelectList ProfessorsDropDown {get; set;}
        public CharacterModel(CharacterDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Characters = _context.Characters.ToList();
        }

        // public void OnPost()
        // {
        //     Professors = _context.Professors.ToList();

        //     _logger.LogWarning("On Post Success");
        // }
    }
}
