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
        public decimal HouseSold => 
        Db.SQL<decimal>("SELECT COUNT(e.Commission) FROM TransactionInfo e WHERE e.Benificary = ?", this).FirstOrDefault();
        public decimal AverageCommission => 
            HouseSold > 0 ? (TotalCommission / HouseSold) : 0;

        public decimal TotalCommission =>
            Db.SQL<decimal>("SELECT SUM(e.Commission) FROM TransactionInfo e WHERE e.Benificary = ?", this).First;

        /*
         *Sales Trend calcuation can be the difference from Average of last one week or three days
         * Take total commission for last three days or last one week or month as required
         * if(lastthreeday commission is > averagecommission)
         *     Calculate the percentage positive trends
         * Else
         *     caluate the -ve percentage trend  
         */
        public int SalesTrend => 0;
        

        public string EditURL => $"/HaseebFranchise/franchise/{this.GetObjectID()}";

        #endregion
    }
}
