using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatPawarah.Models
{
    public class Company
    {
        [DisplayName("Company ID")]
        public int CompanyId { get; set; }

        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Company name is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Enter Name of company")]
        public string CompanyName { get; set; }

        [DisplayName("Open Position")]
        [Required(ErrorMessage = "Position is required")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Enter Position Name")]
        public string OpenPosition { get; set; }

        [DisplayName("Min Salary")]
        [Range(50000, 100000, ErrorMessage = "Enter Valid Minimum Salary")]
        public decimal MinSalary { get; set; }

        [DisplayName("Max Salary")]
        [Range(50000, 100000, ErrorMessage = "Enter Valid Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(13, MinimumLength = 3, ErrorMessage = "Enter Location")]
        public string Location { get; set; }

        [DisplayName("Provides Sponsorship")]
        public bool ProvidesSponsorship { get; set; }

        [DisplayName("Operates Outside US")]
        public bool OperatesOutsideUS { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Year Founded")]
        public DateTime YearFounded { get; set; }

        public List<Candidate> Candidates { get; set; }

        [DisplayName("Industry Associated")]
        public Industry IndustryAssociated { get; set; }
        [DisplayName("Industry Associated ID")]
        public int IndustryAssociatedId { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Enter valid Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [DisplayName("Website Url")]
        [Required(ErrorMessage = "Website Url is required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Enter your website url")]
        [Url]
        public string WebsiteUrl { get; set; }

        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Contact Number is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Enter valid Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }
    }
}
