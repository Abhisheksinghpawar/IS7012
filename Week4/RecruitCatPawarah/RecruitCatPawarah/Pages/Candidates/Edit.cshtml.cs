using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatPawarah.Data;
using RecruitCatPawarah.Models;

namespace RecruitCatPawarah.Pages.Candidates
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatPawarah.Data.RecruitCatPawarahContext _context;

        public EditModel(RecruitCatPawarah.Data.RecruitCatPawarahContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate
                .Include(c => c.CompanyAssociated)
                .Include(c => c.IndustryAssociated)
                .Include(c => c.JobTitleAssociate).FirstOrDefaultAsync(m => m.CandidateId == id);

            if (Candidate == null)
            {
                return NotFound();
            }
           ViewData["CompanyAssociatedId"] = new SelectList(_context.Company, "CompanyId", "CompanyName");
           ViewData["IndustryAssociatedId"] = new SelectList(_context.Industry, "IndustryId", "IndustryName");
           ViewData["JobTitleAssociateId"] = new SelectList(_context.JobTitle, "JobTitleId", "Title");
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

            _context.Attach(Candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateExists(Candidate.CandidateId))
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

        private bool CandidateExists(int id)
        {
            return _context.Candidate.Any(e => e.CandidateId == id);
        }
    }
}
