using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebAppDemo.Entities;
using WebAppDemo.Interfaces.Repositories;
using WebAppDemo.Interfaces.Services;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo
{
    public class ChiefJudgeService : IChiefJudgeService
    {
        private readonly IChiefJudgeRepository _chiefJudgeRepository;
        private readonly ICaseRepository _caseRepository;

        public ChiefJudgeService(IChiefJudgeRepository chiefJudgeRepository, ICaseRepository caseRepository)
        {
            _chiefJudgeRepository = chiefJudgeRepository;
            _caseRepository = caseRepository;
        }

        public bool AddChiefJudge(CreateChiefJudgeRequestModel model)
        {
            var chiefJudge = new ChiefJudge
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                OtherName = model.OtherName,
                Email = model.Email,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                MailClientId = model.MailClientId,
                DateOfBirth = model.DateOfBirth,
                Gender = model.Gender,
                ChiefJudgePhoto = model.ChiefJudgePhoto,
                Password = model.Password
            };
            var cases = _caseRepository.GetSelectedCases(model.Cases);
                  foreach(var caase in cases)
                  {
                    var chiefJudgeCase = new ChiefJudgeCase
                    {
                        ChiefJudgeId = chiefJudge.Id,
                        ChiefJudge = chiefJudge,
                        CaseId = caase.Id,
                        Case = caase
                    };
                     chiefJudge.ChiefJudgeCases.Add(chiefJudgeCase);
                  }
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
                LastName = chiefJudge.LastName,
                OtherName = chiefJudge.OtherName,
                Email = chiefJudge.Email,
                PhoneNumber = chiefJudge.PhoneNumber,
                Address = chiefJudge.Address,
                ChiefJudgePhoto = chiefJudge.ChiefJudgePhoto,
                DateOfBirth = chiefJudge.DateOfBirth,
                Gender = chiefJudge.Gender,
                Cases = chiefJudge.ChiefJudgeCases.Select(k => new CaseDto
                {
                    Id = k.Id,
                    CaseName = k.Case.CaseName,
                    CaseType = k.Case.CaseType,
                    CaseNumber = k.Case.CaseNumber,
                    CaseStatus = k.Case.CaseStatus,
                    CaseDateCreated = k.Case.CaseDateCreated,
                    CaseDateModified = k.Case.CaseDateModified
                }).ToList()
            };
        }

        public IList<ChiefJudgeDto> GetChiefJudges()
        {
            return _chiefJudgeRepository.GetAll().Select(k => new ChiefJudgeDto
            {
                Id = k.Id,
                FirstName = k.FirstName,
                LastName = k.LastName,
                OtherName = k.OtherName,
                Email = k.Email,
                Address = k.Address,
                PhoneNumber = k.PhoneNumber,
                DateOfBirth = k.DateOfBirth,
                Gender = k.Gender,
                ChiefJudgePhoto = k.ChiefJudgePhoto,
                MailClientFirstName = k.MailClient.MailClientFirstName
            }).ToList();
        }

        public ChiefJudgeDto Login(LoginRequestModel model)
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
                    LastName = chiefJudge.LastName,
                    OtherName = chiefJudge.OtherName,
                    Email = chiefJudge.Email,
                    PhoneNumber = chiefJudge.PhoneNumber,
                    Address = chiefJudge.Address,
                    ChiefJudgePhoto = chiefJudge.ChiefJudgePhoto,
                    DateOfBirth = chiefJudge.DateOfBirth,
                    Gender = chiefJudge.Gender,
                    Cases = chiefJudge.ChiefJudgeCases.Select(k => new CaseDto
                    {
                        Id = k.Id,
                        CaseName = k.Case.CaseName,
                        CaseType = k.Case.CaseType,
                        CaseNumber = k.Case.CaseNumber,
                        CaseStatus = k.Case.CaseStatus,
                        CaseDateCreated = k.Case.CaseDateCreated,
                        CaseDateModified = k.Case.CaseDateModified
                    }).ToList()
                };
            }
        }

        public bool UpdateChiefJudge(int id, UpdateChiefJudgeRequestModel model)
        {
            var chiefJudge = _chiefJudgeRepository.Get(id);
            chiefJudge.FirstName = model.FirstName;
            chiefJudge.LastName = model.LastName;
            chiefJudge.OtherName = model.OtherName;
            chiefJudge.Email = model.Email;
            chiefJudge.PhoneNumber = model.PhoneNumber;
            chiefJudge.Address = model.Address;
            chiefJudge.Gender = model.Gender;
            chiefJudge.DateOfBirth = model.DateOfBirth;
            _chiefJudgeRepository.Update(chiefJudge);
            return true;
        }
    }
}