using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Entities;
using WebAppDemo.Interfaces.Repositories;
using WebAppDemo.Interfaces.Services;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Implementations.Services
{
    public class CaseService : ICaseService
    {
        private readonly ICaseRepository _caseRepository;
        public CaseService(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }

        public bool AddCase(CreateCaseRequestModel model)
        {
            var caase = new Case
            {
                CaseName = model.CaseName,
                CaseStatus = model.CaseStatus,
                CaseNumber = model.CaseNumber,
                CaseType = model.CaseType,
                CaseDateCreated = model.CaseDateCreated,
                CaseDateModified = model.CaseDateModified
            };
            _caseRepository.CreateCase(caase);
            return true;
        }

        public void DeleteCase(int id)
        {
            var caase = _caseRepository.GetCaseById(id);
            _caseRepository.DeleteCase(caase);
        }

        public CaseDto GetCase(int id)
        {
            var caase = _caseRepository.GetCaseById(id);
            return new CaseDto
            {
                Id = caase.Id,
                CaseName = caase.CaseName,
                CaseStatus = caase.CaseStatus,
                CaseNumber = caase.CaseNumber,
                CaseType = caase.CaseType,
                CaseDateCreated = caase.CaseDateCreated,
                CaseDateModified = caase.CaseDateModified
            };
        }

        public IList<CaseDto> GetCases()
        {
            return _caseRepository.GetAllCases().Select(k => new CaseDto
            {
                Id = k.Id,
                CaseName = k.CaseName,
                CaseNumber = k.CaseNumber,
                CaseStatus = k.CaseStatus,
                CaseType = k.CaseType,
                CaseDateCreated = k.CaseDateCreated,
                CaseDateModified = k.CaseDateModified
            }).ToList();
        }

        public bool UpdateCase(int id, UpdateCaseRequestModel model)
        {
            var caase = _caseRepository.GetCaseById(id);
            caase.CaseName = model.CaseName;
            caase.CaseNumber = model.CaseNumber;
            caase.CaseStatus = model.CaseStatus;
            caase.CaseType = model.CaseType;
            caase.CaseDateCreated = model.CaseDateCreated;
            caase.CaseDateModified = model.CaseDateModified;
            _caseRepository.UpdateCase(caase);
            return true;
        }
    }
}
