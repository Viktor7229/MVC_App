using MVC_App_Domain.Models;
using MVC_AppServices.Interfaces;
using MVC_App_DataAccess.Interfaces;
using MVC_App_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Implementations
{
    public class ClientService : IClientService
    {
        private readonly IClientService _clientserviceRepository;

        public ClientService(IClientService clientserviceRepository)
        {
            _clientserviceRepository = clientserviceRepository;
        }
        public void Create(Client entity)
        {
            _clientserviceRepository.Create(entity);
        }
        public  void Delete(int id)
        {
            _clientserviceRepository.Delete(id);
        }
        public List<Client> GetAll()
        {
            return _clientserviceRepository.GetAll(); 
        }
        public void Update(Client entity)
        {
            _clientserviceRepository.Update(entity);
        }
    }
}
