using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebAppDemo.Context;
using WebAppDemo.Entities;
using WebAppDemo.Interfaces.Repositories;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Implementations.Repositories
{
    public class ChiefJudgeRepository : IChiefJudgeRepository
    {
        private readonly WebAppDemoContext _context;
        public ChiefJudgeRepository(WebAppDemoContext context)
        {
            _context = context;
        }

        public ChiefJudge Create(ChiefJudge chiefJudge)
        {
            _context.ChiefJudges.Add(chiefJudge);
            _context.SaveChanges();
            return chiefJudge;
        }

        public void Delete(ChiefJudge chiefJudge)
        {
            _context.ChiefJudges.Remove(chiefJudge);
            _context.SaveChanges();
        }

        public ChiefJudge Get(int id)
        {
            return _context.ChiefJudges.Include(k => k.ChiefJudgeCases).ThenInclude(k => k.Case).SingleOrDefault(k => k.Id == id);
        }

        public List<ChiefJudge> GetAll()
        {
            return _context.ChiefJudges.Include(k => k.MailClient)
               .Include(k => k.ChiefJudgeCases)
               .ThenInclude(k => k.Case)
               .ToList();
        }

        public ChiefJudge GetChiefJudgeByEmail(string email)
        {
            return _context.ChiefJudges.Include(k => k.ChiefJudgeCases).ThenInclude(k => k.Case).SingleOrDefault(k => k.Email == email);
        }

        public ChiefJudge Update(ChiefJudge chiefJudge)
        {
            _context.ChiefJudges.Update(chiefJudge);
            _context.SaveChanges();
            return chiefJudge;
        }
    }
}