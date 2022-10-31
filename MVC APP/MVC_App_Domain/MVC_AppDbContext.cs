using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC_APP.Models;
using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_Domain
{
    public class MVC_AppDbContext : DbContext
    {
        public MVC_AppDbContext(DbContextOptions<MVC_AppDbContext> options)
    : base(options)
        { }

        public DbSet<Book> Book { get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<BookCopies> BookCopies { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Lending> Lending { get; set; }
    } 
}
