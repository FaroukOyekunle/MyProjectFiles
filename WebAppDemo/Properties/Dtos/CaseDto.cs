using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Entities;

namespace WebAppDemo.Properties.Dtos
{
    public class CaseDto
    {
        public int Id { get; set; }
        public string CaseName { get; set; }
        public int CaseNumber { get; set; }
        public string CaseType { get; set; }
        public string CaseStatus { get; set; }
        public DateTime CaseDateCreated { get; set; }
        public DateTime CaseDateModified { get; set; }
        public List<ChiefJudgeDto> ChiefJudges { get; set; } = new List<ChiefJudgeDto>();
    }
    public class CreateCaseRequestModel
    {
        [DisplayName("Case Name")]
        [Required(ErrorMessage = "Case Name is required")]
        [StringLength(70, MinimumLength = 5)]
        public string CaseName { get; set; }
       [Required]
        public int CaseNumber { get; set; }
        [Required]
        public string CaseType { get; set; }
        [Required]
        public string CaseStatus { get; set; }
        [Required]
        public DateTime CaseDateCreated { get; set; }
        public DateTime CaseDateModified { get; set; }
    }
    public class UpdateCaseRequestModel
    {
        [Required]
        public string CaseName { get; set; }
        [Required]
        public int CaseNumber { get; set; }
        [Required]
        public string CaseType { get; set; }
        [Required]
        public string CaseStatus { get; set; }
        [Required]
        public DateTime CaseDateCreated { get; set; }
        [Required]
        public DateTime CaseDateModified { get; set; }
    }
}
