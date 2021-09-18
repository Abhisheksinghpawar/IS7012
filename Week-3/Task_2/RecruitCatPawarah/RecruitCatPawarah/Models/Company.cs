using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatPawarah.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string OpenPosition { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public bool ProvidesSponsorship { get; set; }
        public bool OperatesOutsideUS { get; set; }
        public DateTime YearFounded { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry IndustryAssociated { get; set; }
        public int IndustryAssociatedId { get; set; }
    }
}
