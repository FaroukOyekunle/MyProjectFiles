using System.Collections.Generic;
using System.Linq;
using WebAppDemo.Entities;
using WebAppDemo.Interfaces.Repositories;
using WebAppDemo.Interfaces.Services;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Implementations.Services
{
    public class MailClientService : IMailClientService
    {
        private readonly IMailClientRepository _mailClientRepository;

        public MailClientService(IMailClientRepository mailclientRepository)
        {
            _mailClientRepository = mailclientRepository;
        }

        public bool AddMailClient(CreateMailClientRequestModel model)
        {
            var mailClient = new MailClient
            {
                MailClientFirstName = model.MailClientFirstName,
                MailClientLastName = model.MailClientFirstName,
                MailClientOtherName = model.MailClientOtherName,
                Email = model.Email,
                Address = model.Address,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                Gender = model.Gender,
                MailClientTag = model.MailClientTag,
                MailClientPhoto = model.MailClientPhoto
                
            };
            _mailClientRepository.CreateMailClient(mailClient);
            return true;
        }

        public void DeleteMailClient(int id)
        {
            var mailClient = _mailClientRepository.GetMailClientById(id);
            _mailClientRepository.DeleteMailClient(mailClient);
        }

        public MailClientDto GetMailClient(int id)
        {
            var mailClient = _mailClientRepository.GetMailClientById(id);
            return new MailClientDto
            {
                Id = mailClient.Id,
                MailClientFirstName = mailClient.MailClientFirstName,
                MailClientLastName = mailClient.MailClientLastName,
                MailClientOtherName = mailClient.MailClientOtherName,
                Email = mailClient.Email,
                Password = mailClient.Password,
                PhoneNumber = mailClient.PhoneNumber,
                Gender = mailClient.Gender,
                Address = mailClient.Address,
                MailClientPhoto = mailClient.MailClientPhoto,
                MailClientTag = mailClient.MailClientTag
            };
        }

        public IList<MailClientDto> GetMailClients()
        {
            return _mailClientRepository.GetAllMailClient().Select(k => new MailClientDto
            {
                Id = k.Id,
                MailClientFirstName = k.MailClientFirstName,
                MailClientLastName = k.MailClientLastName,
                MailClientOtherName = k.MailClientOtherName,
                Email = k.Email,
                Password = k.Password,
                Gender = k.Gender,
                PhoneNumber = k.PhoneNumber,
                Address = k.Address,
                MailClientPhoto = k.MailClientPhoto,
                MailClientTag = k.MailClientTag
            }).ToList();
        }

        public bool UpdateMailClient(int id, UpdateMailClientRequestModel model)
        {
            var mailClient = _mailClientRepository.GetMailClientById(id);
            mailClient.MailClientFirstName = model.MailClientFirstName;
            mailClient.MailClientLastName = model.MailClientLastName;
            mailClient.MailClientOtherName = model.MailClientOtherName;
            mailClient.Email = model.Email;
            mailClient.Address = model.Address;
            mailClient.Gender = model.Gender;
            mailClient.PhoneNumber = model.PhoneNumber;

            _mailClientRepository.UpdateMailClient(mailClient);
            return true;
        }
    }
}