using MVC_App_Domain.Models;
using MVC_AppServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Implementations
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherService _publisherRepository;

        public PublisherService(IPublisherService publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }
        public void Create(Publisher entity)
        {
            _publisherRepository.Create(entity);
        }
        public void Delete(int id)
        {
            _publisherRepository.Delete(id);
        }
        public List<Publisher> GetAll()
        {
            return _publisherRepository.GetAll();
        }
        public void Update(Publisher entity)
        {
            _publisherRepository.Update(entity);
        }
    }
}
