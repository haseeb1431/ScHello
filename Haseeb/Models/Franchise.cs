using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haseeb.Models
{
    [Database]
    public class Franchise
    {
        public Corporation Owner { get; set; }
        public Address Location { get; set; }
        public string FranchiseName { get; set; }


        #region Calculated Properties
        public int HouseSold => 0;
        public int AverageCommission => 0;
        public int TotalCommission => 0;
        public int SalesTrend => 0;

        public string EditURL => $"/HaseebFranchise/franchise/{this.GetObjectID()}";

        #endregion
    }
}
