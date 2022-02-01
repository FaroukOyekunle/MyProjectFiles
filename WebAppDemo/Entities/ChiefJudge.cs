using System;
using System.Collections.Generic;

namespace WebAppDemo.Entities
{
    public class ChiefJudge
    {
        public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string OtherName{get; set;}
        public string Email{get; set;}
        public string PhoneNumber{get; set;}
        public string Address{get; set;}
        public DateTime DateOfBirth{get; set;}
        public string Gender {get; set;}
        public string ChiefJudgePhoto { get; set; }
        public string Password { get; set; }
        public int MailClientId { get; set; }
        public MailClient MailClient { get; set; }
        public ICollection<ChiefJudgeCase> ChiefJudgeCases { get; set; } = new List<ChiefJudgeCase>();
    }
}