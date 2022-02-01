using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationApITest.Dtos
{
    public class ChiefJudgeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class CreateChiefJudgeRequestModel
    {
        [DisplayName("ChiefJudge FirstName")]
        [Required(ErrorMessage = "ChiefJudge FirstName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        [DisplayName("ChiefJudge's Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber Field Is required")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
    public class UpdateChiefJudgeRequestModel
    {
        [DisplayName("ChiefJudge FirstName")]
        [Required(ErrorMessage = "ChiefJudge FirstName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        [DisplayName("ChiefJudge's Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber Field Is required")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
    public class LoginChiefJudgeRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

