using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Context;
using WebAppDemo.Entities;
using WebAppDemo.Interfaces.Repositories;

namespace WebAppDemo.Implementations.Repositories
{
    public class CaseRepository : ICaseRepository
    {
        private readonly WebAppDemoContext _context;
        public CaseRepository(WebAppDemoContext context)
        {
            _context = context;
        }

        public Case CreateCase(Case Case)
        {
            _context.Cases.Add(Case);
            _context.SaveChanges();
            return Case;
        }

        public void DeleteCase(Case Case)
        {
            _context.Cases.Remove(Case);
            _context.SaveChanges();
        }

        public List<Case> GetAllCases()
        {
            return _context.Cases.ToList();
        }

        public Case GetCaseById(int id)
        {
            return _context.Cases.Find(id);
        }

        public IEnumerable<Case> GetSelectedCases(IList<int> ids)
        {
            return _context.Cases.Where(c => ids.Contains(c.Id)).ToList();
        }

        public Case UpdateCase(Case Case)
        {
            _context.Cases.Update(Case);
            _context.SaveChanges();
            return Case;
        }
    }
}
