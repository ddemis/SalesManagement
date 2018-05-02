using SM.Api.Models.SalesMen;
using System.Collections.Generic;
using System.Linq;

namespace SM.Api.Validators
{
    public class InputDataValidator
    {
        public static bool ValidateSalesMenDistrictRelation(IList<SalesManDetailsModel> salesManDetailsModel)
        {
            return salesManDetailsModel.Where(o => o.RepsonsabilityType == Business.Entities.SalesMen.SalesManResponsabilityTypes.Primary).Count() == 1;
        }
    }
}