using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatPawarah.Models;

namespace RecruitCatPawarah.Data
{
    public class RecruitCatPawarahContext : DbContext
    {
        public RecruitCatPawarahContext (DbContextOptions<RecruitCatPawarahContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatPawarah.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatPawarah.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatPawarah.Models.Company> Company { get; set; }

        public DbSet<RecruitCatPawarah.Models.Candidate> Candidate { get; set; }
    }
}
