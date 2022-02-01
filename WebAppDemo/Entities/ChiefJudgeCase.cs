using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Entities
{
    public class ChiefJudgeCase
    {
        public int Id { get; set; }
        public int ChiefJudgeId { get; set; }
        public ChiefJudge ChiefJudge { get; set; }
        public int CaseId { get; set; }
        public Case Case {get; set; }

    }
}
