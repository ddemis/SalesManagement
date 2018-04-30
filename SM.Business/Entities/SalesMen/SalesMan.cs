using System;

namespace SM.Business.Entities.SalesMen
{
    [Serializable]
    public class SalesMan
    {
        public int SalesManId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
