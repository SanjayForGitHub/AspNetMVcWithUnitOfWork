using AspNetMvcWithUnitOfWork.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspNetMvcWithUnitOfWork.Domain.Entities
{
    [Table("Contacts")]
    public class Contact:Entity<Int32>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
