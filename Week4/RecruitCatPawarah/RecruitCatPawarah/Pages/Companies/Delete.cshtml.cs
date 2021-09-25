using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPawarah.Data;
using RecruitCatPawarah.Models;

namespace RecruitCatPawarah.Pages.Companies
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatPawarah.Data.RecruitCatPawarahContext _context;

        public DeleteModel(RecruitCatPawarah.Data.RecruitCatPawarahContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.IndustryAssociated).FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
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

            Company = await _context.Company.FindAsync(id);

            if (Company != null)
            {
                _context.Company.Remove(Company);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
