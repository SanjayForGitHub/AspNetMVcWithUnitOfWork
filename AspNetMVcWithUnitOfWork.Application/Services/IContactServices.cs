using AspNetMvcWithUnitOfWork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVcWithUnitOfWork.Application.Services
{
    public interface IContactServices
    {
        Task<IEnumerable<Contact>> GetAll();
    }
}
