using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcWithUnitOfWork.Domain.Entities;

namespace AspNetMVcWithUnitOfWork.Application.Services
{
    public class ContactServices : IContactServices
    {
        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
