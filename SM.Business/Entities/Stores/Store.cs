using System;
using System.Collections.Generic;
using System.Text;

namespace SM.Business.Entities.Stores
{
    [Serializable]
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }

        public int DistrictId { get; set; }
    }
}
