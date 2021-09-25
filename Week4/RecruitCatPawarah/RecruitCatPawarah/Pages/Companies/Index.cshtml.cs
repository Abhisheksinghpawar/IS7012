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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatPawarah.Data.RecruitCatPawarahContext _context;

        public IndexModel(RecruitCatPawarah.Data.RecruitCatPawarahContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.IndustryAssociated).ToListAsync();
        }
    }
}
