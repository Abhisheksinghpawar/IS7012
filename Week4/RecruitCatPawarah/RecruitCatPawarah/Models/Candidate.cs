using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatPawarah.Models
{
    public class Candidate
    {
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(13, MinimumLength = 3, ErrorMessage = "Enter your first name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(13, MinimumLength = 3, ErrorMessage = "Enter your last name")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        [Range(50000,100000,ErrorMessage = "Enter Valid Target Salary")]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(13, MinimumLength = 1, ErrorMessage = "Enter gender M/F/O")]
        public string Gender { get; set; }

        [DisplayName("Highest Qualification")]
        [Required(ErrorMessage = "Highest Degree is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Enter last earned degree")]
        public string HighestQualification { get; set; }

        [DisplayName("Years Worked Outside US")]
        [Range(0, 100, ErrorMessage = "Enter Valid Outside US Experience")]
        public int? YearsWorkedOutsideUS { get; set; }

        [DisplayName("Company Associated")]
        public Company CompanyAssociated { get; set; }

        [DisplayName("Company Associated ID")]
        public int? CompanyAssociatedId { get; set; }

        [DisplayName("Job Title Associate")]
        public JobTitle JobTitleAssociate { get; set; }

        [DisplayName("Job Title Associate ID")]
        public int JobTitleAssociateId { get; set; }

        [DisplayName("Industry Associated")]
        public Industry IndustryAssociated { get; set; }

        [DisplayName("Industry Associated ID")]
        public int IndustryAssociatedId { get; set; }
    }
}
