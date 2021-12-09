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
    public class IndexModel : PageModel
    {
        private readonly Dirarys_Final_Project.Models.CharacterDbContext _context;

        public IndexModel(Dirarys_Final_Project.Models.CharacterDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Characters.Select(c => c);

            switch (CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(c => c.Name);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(c => c.Name);
                    break;
                case "age_asc":
                    query = query.OrderBy(c => c.Age);
                    break;
                case "age_desc":
                    query = query.OrderByDescending(c => c.Age);
                    break;
                case "height_asc":
                    query = query.OrderBy(c => c.Height);
                    break;
                case "height_desc":
                    query = query.OrderByDescending(c => c.Height);
                    break;
                case "weight_asc":
                    query = query.OrderBy(c => c.Weight);
                    break;
                case "weight_desc":
                    query = query.OrderByDescending(c => c.Weight);
                    break;
                case "race_asc":
                    query = query.OrderBy(c => c.Race);
                    break;
                case "race_desc":
                    query = query.OrderByDescending(c => c.Race);
                    break;
                case "spec_asc":
                    query = query.OrderBy(c => c.Specialization);
                    break;
                case "spec_desc":
                    query = query.OrderByDescending(c => c.Specialization);
                    break;
            }

            Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
