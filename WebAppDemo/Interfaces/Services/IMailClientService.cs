using System.Collections.Generic;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Interfaces.Services
{
   public interface IMailClientService
   {
        bool AddMailClient(CreateMailClientRequestModel model);
        bool UpdateMailClient(int id, UpdateMailClientRequestModel model);
        MailClientDto GetMailClient(int id);
        IList<MailClientDto> GetMailClients();
        void DeleteMailClient(int id);
   }
}