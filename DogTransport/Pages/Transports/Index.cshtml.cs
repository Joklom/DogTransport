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
    public class IndexModel : PageModel
    {
        private readonly DogTransport.Data.ApplicationDbContext _context;

        public IndexModel(DogTransport.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Transport> Transport { get;set; }

        public async Task OnGetAsync()
        {
            Transport = await _context.Transport.ToListAsync();
        }
    }
}
