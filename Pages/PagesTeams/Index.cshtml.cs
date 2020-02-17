using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CAP2.Data;
using CAP2.Models;

namespace CAP2.PagesTeams
{
    public class IndexModel : PageModel
    {
        private readonly CAP2.Data.TeamContext _context;

        public IndexModel(CAP2.Data.TeamContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Teams.ToListAsync();
        }
    }
}
