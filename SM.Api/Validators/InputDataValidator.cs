using SM.Api.Models.SalesMen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Api.Validators
{
    public class InputDataValidator
    {
        public static bool ValidateSalesMenDistrictRelation(IList<SalesManDetailsModel> salesManDetailsModel)
        {
            return salesManDetailsModel.Any(o => o.RepsonsabilityType == Business.Entities.SalesMen.SalesManResponsabilityTypes.Primary);
        }
    }
}