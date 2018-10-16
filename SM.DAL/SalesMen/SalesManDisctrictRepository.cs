using SM.Business.Repository.SalesMen;
using SM.Business.Services.SalesMen.CustomEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SM.DAL.SalesMen
{
    internal class SalesManDistrictRepository : ISalesManDistrictRepository
    {
        public async Task<bool> AddUpdateSalesManDistrictAndResponsabilityAsync(IList<SalesManDetails> salesMenDetails)
        {
            var salesMenDetailsXml = new XElement("SalesMenDetails");
            
            foreach (var salesManDetails in salesMenDetails)
            {
                var item = new XElement("SalesManDetails");
                item.Add(new XElement("DistrictId", salesManDetails.DistrictId));
                item.Add(new XElement("SalesManId", salesManDetails.SalesManId));
                item.Add(new XElement("RepsonsabilityTypeId", salesManDetails.RepsonsabilityType.HasValue ? (int)salesManDetails.RepsonsabilityType : (object) DBNull.Value));

                salesMenDetailsXml.Add(item);
            }ertertert

            SqlParameter salesMenDetailsXmlParam = new SqlParameter("@salesMenDetailsXml", salesMenDetailsXml.ToString(SaveOptions.DisableFormatting));

            using (var context = new RepositoryContext())
            {
                await context.Database.ExecuteSqlCommandAsync("SalesMen_Districts_AddUpdate @salesMenDetailsXml", salesMenDetailsXmlParam);
            }

            return true;
        }
    }
}