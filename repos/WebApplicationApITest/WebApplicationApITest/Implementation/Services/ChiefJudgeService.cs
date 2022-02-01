using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApITest.Dtos;
using WebApplicationApITest.Entities;
using WebApplicationApITest.Interface.IRepository;
using WebApplicationApITest.Interface.IService;

namespace WebApplicationApITest.Implementation.Services
{
    public class ChiefJudgeService : IChiefJudgeService
    {
        private readonly IChiefJudgeRepository _chiefJudgeRepository;
        public ChiefJudgeService(IChiefJudgeRepository chiefJudgeRepository)
        {
            _chiefJudgeRepository = chiefJudgeRepository;
        }

        public bool AddChiefJudge(CreateChiefJudgeRequestModel model)
        {
            var chiefJudge = new ChiefJudge
            {
                FirstName = model.FirstName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Password = model.Password
            };
            _chiefJudgeRepository.Create(chiefJudge);
            return true;
        }

        public void DeleteChiefJudge(int id)
        {
            var chiefJudge = _chiefJudgeRepository.Get(id);
            _chiefJudgeRepository.Delete(chiefJudge);
        }

        public ChiefJudgeDto GetChiefJudge(int id)
        {
            var chiefJudge = _chiefJudgeRepository.Get(id);
            return new ChiefJudgeDto
            {
                Id = chiefJudge.Id,
                FirstName = chiefJudge.FirstName,
                Email = chiefJudge.Email,
                PhoneNumber = chiefJudge.PhoneNumber
            };
        }

        public IList<ChiefJudgeDto> GetChiefJudges()
        {
            return _chiefJudgeRepository.GetAll().Select(k => new ChiefJudgeDto
            {
                Id = k.Id,
                FirstName = k.FirstName,
                Email = k.Email,
                PhoneNumber = k.PhoneNumber
            }).ToList();
        }

        public ChiefJudgeDto Login(LoginChiefJudgeRequestModel model)
        {
            var chiefJudge = _chiefJudgeRepository.GetChiefJudgeByEmail(model.Email);
            if (chiefJudge == null || chiefJudge.Password != model.Password)
            {
                return null;
            }
            else
            {
                return new ChiefJudgeDto
                {

                    Id = chiefJudge.Id,
                    FirstName = chiefJudge.FirstName,
                    Email = chiefJudge.Email,
                    PhoneNumber = chiefJudge.PhoneNumber
                };
            }
        }
        public bool UpdateChiefJudge(int id, UpdateChiefJudgeRequestModel model)
        {
            var chiefJudge = _chiefJudgeRepository.Get(id);
            chiefJudge.FirstName = model.FirstName;
            chiefJudge.Email = model.Email;
            chiefJudge.PhoneNumber = model.PhoneNumber;
            _chiefJudgeRepository.Update(chiefJudge);
            return true;
        }
    }
}
