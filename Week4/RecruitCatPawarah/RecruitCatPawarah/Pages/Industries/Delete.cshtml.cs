using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPawarah.Data;
using RecruitCatPawarah.Models;

namespace RecruitCatPawarah.Pages.Industries
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatPawarah.Data.RecruitCatPawarahContext _context;

        public DeleteModel(RecruitCatPawarah.Data.RecruitCatPawarahContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.IndustryId == id);

            if (Industry == null)
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

            Industry = await _context.Industry.FindAsync(id);

            if (Industry != null)
            {
                _context.Industry.Remove(Industry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
