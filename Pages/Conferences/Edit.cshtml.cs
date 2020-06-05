using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataHappy.Data;
using DataHappy.Models;

namespace DataHappy.Pages.Conferences
{
    public class EditModel : PageModel
    {
        private readonly DataHappy.Data.DataHappyContext _context;

        public EditModel(DataHappy.Data.DataHappyContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Conference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConferenceExists(Conference.ID))
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

        private bool ConferenceExists(int id)
        {
            return _context.Conference.Any(e => e.ID == id);
        }
    }
}
