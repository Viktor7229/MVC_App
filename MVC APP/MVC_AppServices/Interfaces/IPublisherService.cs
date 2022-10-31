using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Interfaces
{
    public interface IPublisherService
    {
        void Create(Publisher entity);
        void Update(Publisher entity);
        List<Publisher> GetAll();
        void Delete(int id);
    }
}
