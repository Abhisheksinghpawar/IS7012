using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatPawarah.Models
{
    public class Industry
    {
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        [DisplayName("Industry Name")]
        [Required(ErrorMessage = "Industry Name is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Enter your Industry Name")]
        public string IndustryName { get; set; }

        [DisplayName("Share Price")]
        [Range(50000, int.MaxValue, ErrorMessage = "Enter Valid Share Price")]
        public decimal? SharePrice { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
