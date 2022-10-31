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
    public class LendingService : ILendingService
    {
        private readonly ILendingService _lendingRepository;


        public LendingService(ILendingService lendingRepository)
        {
            _lendingRepository = lendingRepository;
        }
        public void Create(Lending entity)
        {
            _lendingRepository.Create(entity);
        }
        public void Delete(int id)
        {
            _lendingRepository.Delete(id);
        }
        public List<Lending> GetAll()
        {
            return _lendingRepository.GetAll();
        }
        public void Update(Lending entity)
        {
            _lendingRepository.Update(entity);
        }
    }
}
