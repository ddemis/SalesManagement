using SM.Business.Repository.SalesMen;
using SM.Business.Services.Districts.CustomEntities;
using SM.Business.Services.SalesMen.CustomEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SM.Business.Entities.SalesMen;

namespace SM.DAL.SalesMen
{
    internal class SalesManRepository : ISalesManRepository
    {
        public IList<SalesManDetails> GetSalesMenDetails()
        {
            //todo - daca am timp pt asta pot sa fac o stocata ca exemplu
            IList<SalesManDetails> salesManDetails = new List<SalesManDetails>();
            try
            {
                using (var context = new RepositoryContext())
                {
                    salesManDetails = ( from salesMan in context.SalesMen
                                        join salesManDistrict in context.SalesMenDistricts on salesMan.SalesManId equals salesManDistrict.SalesManId
                                        into g
                                        from result in g.DefaultIfEmpty()
                                        select new SalesManDetails
                                                {
                                                    SalesManId = salesMan.SalesManId,
                                                    SalesUIId = 0,
                                                    FirstName = salesMan.FirstName,
                                                    LastName = salesMan.LastName,
                                                    DistrictId = result.DistrictId,
                                                    RepsonsabilityType = (SalesManResponsabilityTypes)result.SalesManResponsabilityTypeId
                                                }
                                        ).ToList();
                    return salesManDetails;
                }
            }
            catch (Exception ex)
            {
                //todo - do not throw
                throw ex;
            }
        }
    }
}
