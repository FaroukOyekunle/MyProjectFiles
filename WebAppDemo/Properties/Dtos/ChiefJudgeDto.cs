using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebAppDemo.Entities;

namespace WebAppDemo.Properties.Dtos
{
    public class ChiefJudgeDto
    {
         public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string OtherName{get; set;}
        public string Email{get; set;}
        public string PhoneNumber{get; set;}
        public string Address{get; set;}
        public string ChiefJudgePhoto { get; set; }
        public DateTime DateOfBirth{get; set;}
        public string Gender {get; set;}
        public int MailClientId{get; set;}
        public string MailClientFirstName{get; set;}
        public ICollection<CaseDto> Cases { get; set; } = new List<CaseDto>();
    }
    
    public class CreateChiefJudgeRequestModel
    {
        [DisplayName("ChiefJudge FirstName")]
        [Required(ErrorMessage = "ChiefJudge FirstName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string FirstName{get; set;}

        [DisplayName("ChiefJudge LastName")]
        [Required(ErrorMessage = "ChiefJudge LastName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string LastName{get; set;}

        [DisplayName("ChiefJudge OtherName")]
        [Required(ErrorMessage = "ChiefJudge OtherName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string OtherName{get; set;}
        [Required]
        public string ChiefJudgePhoto { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email{get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DisplayName("ChiefJudge's Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber Field Is required")]
        public string PhoneNumber{get; set;}

        [Required(ErrorMessage = "ChiefJudge Address is required")]
        [StringLength(200)]
        public string Address{get; set;}
        [Required]
        public DateTime DateOfBirth{get; set;}
        [Required]
        public string Gender {get; set;}
        public int MailClientId { get; set; }
        public IList<int> Cases { get; set; } = new List<int>();
    }
    public class UpdateChiefJudgeRequestModel
    {
        [DisplayName("ChiefJudge FirstName")]
        [Required(ErrorMessage = "ChiefJudge FirstName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string FirstName{get; set;}

        [DisplayName("ChiefJudge LastName")]
        [Required(ErrorMessage = "ChiefJudge LastName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string LastName{get; set;}

        [DisplayName("ChiefJudge OtherName")]
        [Required(ErrorMessage = "ChiefJudge OtherName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string OtherName{get; set;}

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email{get; set;}

        [DisplayName("ChiefJudge's Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber Field Is required")]
        public string PhoneNumber{get; set;}

        [Required]
        public string Address{get; set;}
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth {get; set;}
    }
    public class LoginRequestModel
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}