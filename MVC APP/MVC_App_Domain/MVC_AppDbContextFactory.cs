using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MVC_App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App.Domain.Models
{
    public class MVC_AppDbContextFactory : IDesignTimeDbContextFactory<MVC_AppDbContext>
    {
        public MVC_AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MVC_AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MVC_AppDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new MVC_AppDbContext(optionsBuilder.Options);
        }
    }
    
    
}
