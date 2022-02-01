
using System.Collections.Generic;
using System.Linq;
using WebAppDemo.Context;
using WebAppDemo.Entities;
using WebAppDemo.Interfaces.Repositories;

namespace WebAppDemo.Implementations.Repositories
{
    public class MailClientRepository : IMailClientRepository
    {
         private readonly WebAppDemoContext _context;
        public MailClientRepository(WebAppDemoContext context)
        {
            _context = context;
        }

        public MailClient CreateMailClient(MailClient mailClient)
        {
            _context.MailClients.Add(mailClient);
            _context.SaveChanges();
            return mailClient;
        }

        public void DeleteMailClient(MailClient mailClient)
        {
            _context.MailClients.Remove(mailClient);
            _context.SaveChanges();
        }

        public List<MailClient> GetAllMailClient()
        {
            return _context.MailClients.ToList();
        }

        public MailClient GetMailClientById(int id)
        {
            return _context.MailClients.Find(id);
        }

        public IEnumerable<MailClient> GetSelectedMailClient(IList<int> Ids)
        {
            return _context.MailClients.Where(c => Ids.Contains(c.Id)).ToList();
        }

        public MailClient UpdateMailClient(MailClient mailClient)
        {
            _context.MailClients.Update(mailClient);
            _context.SaveChanges();
            return mailClient;
        }
    }
}