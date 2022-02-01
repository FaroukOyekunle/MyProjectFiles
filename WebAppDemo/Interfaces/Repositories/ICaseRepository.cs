using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Entities;

namespace WebAppDemo.Interfaces.Repositories
{
    public interface ICaseRepository
    {
        Case CreateCase(Case Case);
        Case UpdateCase(Case Case);
        Case GetCaseById(int id);
        List<Case> GetAllCases();
        void DeleteCase(Case Case);
        IEnumerable<Case> GetSelectedCases(IList<int> ids);
    }
}
