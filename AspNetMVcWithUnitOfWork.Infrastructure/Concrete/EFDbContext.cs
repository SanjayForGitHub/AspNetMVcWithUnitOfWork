using AspNetMvcWithUnitOfWork.Domain.Entities;
using System.Data.Entity;

namespace AspNetMvcWithUnitOfWork.Infrastructure
{
    public class EFDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
