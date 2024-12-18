using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperPC.Data;
using SuperPC.Models;

namespace SuperPC.Pages
{
    public class AddPCModel : PageModel
    {
        private readonly SuperPC.Data.ApplicationDbContext _context;

        public AddPCModel(SuperPC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CompletePC CompletePC { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CompletePCs.Add(CompletePC);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
