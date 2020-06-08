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
    public class DeleteModel : PageModel
    {
        private readonly DataHappy.Data.DataHappyContext _context;

        public DeleteModel(DataHappy.Data.DataHappyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Conference Conference { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conference = await _context.Conference.FirstOrDefaultAsync(m => m.ID == id);

            if (Conference == null)
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

            Conference = await _context.Conference.FindAsync(id);

            if (Conference != null)
            {
                _context.Conference.Remove(Conference);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
