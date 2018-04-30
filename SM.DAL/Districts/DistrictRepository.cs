using SM.Business.Repository.Districts;
using System;
using System.Collections.Generic;
using System.Text;
using SM.Business.Entities.Districts;
using SM.Business.Services.Districts.CustomEntities;
using System.Linq;
using SM.Business.Entities.SalesMen;

namespace SM.DAL.Districts
{
    internal class DistrictRepository : IDistrictRepository
    {
        //TODO - metodele async
        public bool AddDistrict(District district)
        {
            try
            {
                using (var context = new RepositoryContext())
                {
                    context.Districts.Add(district);
                    int result = context.SaveChanges();
                    return result == 1;
                }
            }
            catch(Exception ex)
            {

                return false;
            }
        }

        public IList<District> GetAllDistricts()
        {
            //todo - contruiesc ceva resulturi cu mesaj de eroare + data
            try
            {
                using (var context = new RepositoryContext())
                {
                    return context.Districts.ToList();
                }
            }
            catch (Exception ex)
            {
                //todo - do not throw
                throw ex;
            }
        }

        public DistrictDetails GetDistrictDetailsByDistrictId(int districtId)
        {
            //todo - contruiesc ceva resulturi cu mesaj de eroare + data
            DistrictDetails districtDetails = new DistrictDetails();
            try
            {
                using (var context = new RepositoryContext())
                {
                    districtDetails.DistrictId = districtId;
                    districtDetails.Stores = context.Stores.Where(o => o.DistrictId == districtId).ToList();
                    districtDetails.SalesMenDetails = (from salesMan in context.SalesMen
                                                       join salesManDistrict in context.SalesMenDistricts on salesMan.SalesManId equals salesManDistrict.SalesManId
                                                       where salesManDistrict.DistrictId == districtId
                                                       select new SalesManDetails
                                                       {
                                                           SalesManId = salesMan.SalesManId,
                                                           SalesUIId = 0,
                                                           FirstName = salesMan.FirstName,
                                                           LastName = salesMan.LastName,
                                                           RepsonsabilityType = (SalesManResponsabilityTypes)salesManDistrict.SalesManResponsabilityTypeId
                                                       }).ToList();
                    return districtDetails;
                }
            }
            catch (Exception ex)
            {
                //todo - do not throw
                throw ex;
            }
        }

        //public DistrictDetailsResult GetDistrictDetails(int startRowNo, int noOfRowsToGet)
        //{
        //    DistrictDetailsResult districtResult = new DistrictDetailsResult();
        //    try
        //    {
        //        using (var context = new RepositoryContext())
        //        {
        //            districtResult.TotalNoOfDistricts = context.Districts.Count();
        //            districtResult.Districts = context.Districts.OrderBy(o => o.DistrictId)
        //                .Skip(startRowNo - 1)
        //                .Take(noOfRowsToGet).Select(o => new DistrictDetails { DistrictId = o.DistrictId, DistrictName = o.Name }).ToList();

        //            if (districtResult.Districts != null)
        //            {
        //                foreach (var district in districtResult.Districts)
        //                {
        //                    district.Stores = context.Stores.Where(o => o.DistrictId == district.DistrictId).ToList();
        //                    district.SalesMenDetails = (from salesMan in context.SalesMen
        //                                                join salesManDistrict in context.SalesMenDistricts on salesMan.SalesManId equals salesManDistrict.SalesManId
        //                                                where salesManDistrict.DistrictId == district.DistrictId
        //                                                select new SalesManDetails
        //                                                {
        //                                                    SalesManId = salesMan.SalesManId,
        //                                                    SalesUIId = 0,
        //                                                    FirstName = salesMan.FirstName,
        //                                                    LastName = salesMan.LastName,
        //                                                    RepsonsabilityType = (SalesManResponsabilityTypes)salesManDistrict.SalesManResponsabilityTypeId
        //                                                }).ToList();
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

                
        //    }

        //    return districtResult;
        //}
    }
}
