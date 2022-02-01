using System.Collections.Generic;
using WebAppDemo.Entities;

namespace WebAppDemo.Interfaces.Repositories
{
     public interface IMailClientRepository
     {
        MailClient CreateMailClient(MailClient mailclient);
        MailClient UpdateMailClient(MailClient mailclient);
        MailClient GetMailClientById(int id);
        List<MailClient> GetAllMailClient();
        void DeleteMailClient(MailClient mailclient);
        IEnumerable<MailClient> GetSelectedMailClient(IList<int> Ids);
     }
}