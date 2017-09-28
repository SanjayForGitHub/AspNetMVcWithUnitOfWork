using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcWithUnitOfWork.Domain.Common
{
    public interface IModifiedInfo
    {
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
