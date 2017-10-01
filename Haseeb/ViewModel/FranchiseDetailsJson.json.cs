using Haseeb.Models;
using Starcounter;

namespace Haseeb.ViewModel
{
    partial class FranchiseDetailsJson : Json
    {
        //public QueryResultRows<Corporation> AllCorporation => Db.SQL<Corporation>("SELECT c FROM Corporation c ");


        #region Calculated Properties

        public int HouseSold => 0;
        public int AverageCommission => 0;
        public int TotalCommission => 0;
        public int SalesTrend => 0;

        #endregion

      
    }
}
