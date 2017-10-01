using Haseeb.Models;
using Starcounter;

namespace Haseeb.ViewModel
{
    partial class CorporationJson : Json
    {

        public QueryResultRows<Corporation> AllCorporation => Db.SQL<Corporation>("SELECT c FROM Corporation c ");

        static CorporationJson()
        {
            //DefaultTemplate.AllCorporation.
            //DefaultTemplate Franchises.ElementType.InstanceType = typeof(FranchiseDetailsJson);
        }
        
        void Handle(Input.CreateCorpTrigger action)
        {
            //Get the View data and create a new Corporation. 
            //TODO: Check if already exist so let's not create it
            var corp = new Corporation()
            {
                CorpName = this.CorpName
            };

            //Create the corporation and save respective changes
            Transaction.Commit();
        }

        void Handle(Input.CreateFranchiseTrigger action)
        {
            new Franchise()
            {
                FranchiseName = this.FranchiseName,
                //TODO: how to get the current Item in the collection
                Owner = this.AllCorporation.First
            };

            Transaction.Commit();
        }

        void Handle(Input.SortOnTrigger action)
        {
            //TODO: Server Side sorting or Client Side
            switch (action.Value)
            {
                case 5:
                    RefereshFranchise(FranchiseKPIs.HomeSold);
                    break;
                case 6:
                    RefereshFranchise(FranchiseKPIs.TotalCommission);
                    break;
                case 7:
                    RefereshFranchise(FranchiseKPIs.AverageCommission);
                    break;
                case 8:
                    RefereshFranchise(FranchiseKPIs.PositiveTrend);
                    break;
                default:
                    break;
            }
        }

        private void RefereshFranchise(FranchiseKPIs sortingKPI)
        {
            
        }

        private enum FranchiseKPIs { HomeSold=5,TotalCommission, AverageCommission, PositiveTrend}
    }
}
