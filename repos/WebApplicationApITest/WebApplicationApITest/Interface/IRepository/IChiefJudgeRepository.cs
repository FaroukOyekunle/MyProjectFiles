using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApITest.Entities;

namespace WebApplicationApITest.Interface.IRepository
{
   public  interface IChiefJudgeRepository
   {
        ChiefJudge Create(ChiefJudge chiefJudge);
        ChiefJudge Update(ChiefJudge chiefJudge);
        ChiefJudge Get(int id);
        List<ChiefJudge> GetAll();
        void Delete(ChiefJudge chiefJudge);
        ChiefJudge GetChiefJudgeByEmail(string email);
   }
}
