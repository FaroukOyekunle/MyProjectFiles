using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApITest.Dtos;

namespace WebApplicationApITest.Interface.IService
{
   public interface IChiefJudgeService
   {
        bool AddChiefJudge(CreateChiefJudgeRequestModel model);
        bool UpdateChiefJudge(int id, UpdateChiefJudgeRequestModel model);
        ChiefJudgeDto GetChiefJudge(int id);
        IList<ChiefJudgeDto> GetChiefJudges();
        void DeleteChiefJudge(int id);
        ChiefJudgeDto Login(LoginChiefJudgeRequestModel model);
    }
}
