using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatPawarah.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Gender { get; set; }
        public string HighestQualification { get; set; }
        public int? YearsWorkedOutsideUS { get; set; }
        public Company CompanyAssociated { get; set; }
        public int? CompanyAssociatedId { get; set; }
        public JobTitle JobTitleAssociate { get; set; }
        public int JobTitleAssociateId { get; set; }
        public Industry IndustryAssociated { get; set; }
        public int IndustryAssociatedId { get; set; }
    }
}
