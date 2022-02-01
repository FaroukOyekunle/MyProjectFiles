using System.Collections.Generic;

namespace WebAppDemo.Entities
{
    public class MailClient
    {
          public int Id{get; set;}
          public string MailClientFirstName{ get; set; }
          public string MailClientLastName { get; set; }
          public string MailClientOtherName { get; set; }
          public string Email { get; set; }
          public string MailClientPhoto { get; set; }
          public string Password { get; set; }
          public string Address {get; set;}
          public string Gender { get; set; }
          public string PhoneNumber{get; set;}
          public string MailClientTag { get; set; }
        public ICollection<ChiefJudge> ChiefJudges { get; set; } = new List<ChiefJudge>();

    }
}