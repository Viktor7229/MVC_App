using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Interfaces
{
    public interface ILendingService
    {
        void Create(Lending entity);
        void Update(Lending entity);
        List<Lending> GetAll();
        void Delete(int id);
    }
}
