using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Interfaces
{
    public interface IClientService
    {
        void Create(Client entity);
        void Update(Client entity);

        List<Client> GetAll();

        void Delete(int id);
    }
}
