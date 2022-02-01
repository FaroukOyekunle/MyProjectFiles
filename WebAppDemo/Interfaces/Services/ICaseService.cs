using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Interfaces.Services
{
    public interface ICaseService
    {
        bool AddCase(CreateCaseRequestModel model);
        bool UpdateCase(int id, UpdateCaseRequestModel model);
        CaseDto GetCase(int id);
        IList<CaseDto> GetCases();
        void DeleteCase(int id);
    }
}
