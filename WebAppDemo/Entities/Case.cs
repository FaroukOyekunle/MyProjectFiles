using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Entities
{
    public class Case
    {
        public int Id { get; set; }
        public string CaseName { get; set; }
        public int CaseNumber { get; set; }
        public string CaseType { get; set; }
        public string CaseStatus { get; set; }
        public DateTime CaseDateCreated { get; set; }
        public DateTime CaseDateModified { get; set; }
        public ICollection<ChiefJudgeCase> ChiefJudgeCases { get; set; } = new List<ChiefJudgeCase>();
      

    }
}
