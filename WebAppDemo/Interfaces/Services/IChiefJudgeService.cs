using System.Collections.Generic;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Interfaces.Services
{
     public interface IChiefJudgeService
     {
        bool AddChiefJudge(CreateChiefJudgeRequestModel model);
        bool UpdateChiefJudge(int id, UpdateChiefJudgeRequestModel model);
        ChiefJudgeDto GetChiefJudge(int id);
        IList<ChiefJudgeDto> GetChiefJudges();
        void DeleteChiefJudge(int id);
        ChiefJudgeDto Login(LoginRequestModel model);
    }
}