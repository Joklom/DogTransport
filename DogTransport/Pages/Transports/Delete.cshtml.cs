using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DogTransport.Models;

namespace DogTransport.Pages.Transports
{
    public class DeleteModel : PageModel
    {
        private readonly DogTransport.Data.ApplicationDbContext _context;

        public DeleteModel(DogTransport.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Transport Transport { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transport = await _context.Transport.FirstOrDefaultAsync(m => m.ID == id);

            if (Transport == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transport = await _context.Transport.FindAsync(id);

            if (Transport != null)
            {
                _context.Transport.Remove(Transport);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
