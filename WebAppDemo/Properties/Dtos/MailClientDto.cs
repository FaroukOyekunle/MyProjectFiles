using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebAppDemo.Entities;

namespace WebAppDemo.Properties.Dtos
{
    public class MailClientDto
    {
          public int Id { get; set; }
        public string MailClientFirstName { get; set; }
        public string MailClientLastName { get; set; }
        public string MailClientOtherName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address{get; set;}
        public string MailClientPhoto { get; set; }
        public string Gender{get; set;}
        public string PhoneNumber{get; set;}
        public string MailClientTag { get; set; }
        public List<ChiefJudgeDto> ChiefJudges { get; set; } = new List<ChiefJudgeDto>();
    }
    public class CreateMailClientRequestModel
    {
        [DisplayName("MailClient FirstName")]
        [Required(ErrorMessage = "MailClient FirstName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string MailClientFirstName { get; set; }

        [DisplayName("MailClient LastName")]
        [Required(ErrorMessage = "MailClient LastName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string MailClientLastName { get; set; }

        [DisplayName("MailClient OtherName")]
        [Required(ErrorMessage = "MailClient OtherName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string MailClientOtherName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
      //  [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string MailClientPhoto { get; set; }

        [Required(ErrorMessage = "MailClient Address is required")]
        [StringLength(200)]
        public string Address{get; set;}
        public int ChiefJudgeId { get; set; }
        [Required]
        public string Gender{get; set;}

        [DisplayName("MailClient's Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber Field Is required")]    
        public string PhoneNumber{get; set;}

        [Required]
        public string MailClientTag { get; set; }
    }
    public class UpdateMailClientRequestModel
    {
        [DisplayName("MailClient FirstName")]
        [Required(ErrorMessage = "MailClient FirstName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string MailClientFirstName { get; set; }

        [DisplayName("MailClient LastName")]
        [Required(ErrorMessage = "MailClient LastName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string MailClientLastName { get; set; }

        [DisplayName("MailClient OtherName")]
        [Required(ErrorMessage = "MailClient OtherName is required")]
        [StringLength(70, MinimumLength = 5)]
        public string MailClientOtherName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "MailClient Address is required")]
        [StringLength(200)]
        public string Address{get; set;}
        [Required]
        public string Gender{get; set;}

        [DisplayName("MailClient's Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber Field Is required")]
        public string PhoneNumber{get; set;}
        
    }
}