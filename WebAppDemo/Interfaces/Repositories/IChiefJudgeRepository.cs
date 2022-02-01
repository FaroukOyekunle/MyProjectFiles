using System.Collections.Generic;
using WebAppDemo.Entities;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Interfaces.Repositories
{
    public interface IChiefJudgeRepository
    {
        ChiefJudge Create(ChiefJudge chiefJudge);
        ChiefJudge Update(ChiefJudge chiefJudge);
        ChiefJudge Get(int id);
        List<ChiefJudge> GetAll();
        void Delete(ChiefJudge chiefJudge);
        ChiefJudge GetChiefJudgeByEmail(string email);
      
    }
}