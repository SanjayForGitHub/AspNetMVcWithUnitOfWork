using AspNetMvcWithUnitOfWork.Domain.Common;

namespace AspNetMvcWithUnitOfWork.Domain.Entities
{
    public class Address:Entity<int>
    {
        public string StreetAddress { get; set; }
        public string CompleteAddress { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}