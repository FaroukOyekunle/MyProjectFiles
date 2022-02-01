
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApITest.Context;
using WebApplicationApITest.Dtos;
using WebApplicationApITest.Entities;
using WebApplicationApITest.Interface.IRepository;

namespace WebApplicationApITest.Implementation.Repository
{
    public class ChiefJudgeRepository : IChiefJudgeRepository
    {
        private readonly WebApplicationAPITestContext _context;
        public ChiefJudgeRepository(WebApplicationAPITestContext context)
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
            return _context.ChiefJudges.Find(id);
        }

        public List<ChiefJudge> GetAll()
        {
            return _context.ChiefJudges.Select(a => new ChiefJudge()).ToList();
              
        }

        public ChiefJudge GetChiefJudgeByEmail(string email)
        {
            throw new Exception();
        }

        public ChiefJudge Update(ChiefJudge chiefJudge)
        {
            _context.ChiefJudges.Update(chiefJudge);
            _context.SaveChanges();
            return chiefJudge;
        }
    }
}
