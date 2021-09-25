using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatPawarah.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(13, MinimumLength = 4, ErrorMessage = "Enter valid Title")]
        public string Title { get; set; }

        [DisplayName("Min Salary")]
        [Range(50000, 100000, ErrorMessage = "Enter Valid Minimum Salary")]
        public decimal MinSalary { get; set; }

        [DisplayName("Max Salary")]
        [Range(50000, 100000, ErrorMessage = "Enter Valid Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [DisplayName("Is Remote Location")]
        public bool IsRemoteLocation { get; set; }

        [DisplayName("Job Description")]
        [Required(ErrorMessage = "Job description is required")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Enter the Job Description")]
        public string JobDescription { get; set; }
        
        public List<Candidate> CandidatesAssociate { get; set; }
    }
}
