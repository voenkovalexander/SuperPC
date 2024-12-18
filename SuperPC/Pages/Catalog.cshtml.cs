using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperPC.Data;
using SuperPC.Models;

namespace SuperPC.Pages
{
    public class CatalogModel : PageModel
    {

        public List<CompletePC> completePCs;

        private ApplicationDbContext _context;

        public CatalogModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            completePCs = _context.CompletePCs.ToList();
        }
    }
}
