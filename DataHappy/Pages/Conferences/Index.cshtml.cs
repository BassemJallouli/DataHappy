using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataHappy.Data;
using DataHappy.Models;

namespace DataHappy.Pages.Conferences
{
    public class IndexModel : PageModel
    {
        private readonly DataHappy.Data.DataHappyContext _context;

        public IndexModel(DataHappy.Data.DataHappyContext context)
        {
            _context = context;
        }

        public IList<Conference> Conference { get;set; }

        public async Task OnGetAsync()
        {
            Conference = await _context.Conference.ToListAsync();
        }
    }
}
