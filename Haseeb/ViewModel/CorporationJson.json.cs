using Haseeb.Models;
using Starcounter;
using System.Collections.Generic;
using System.Linq;

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

        
        
        [CorporationJson_json.AllCorporation]
        partial class CorporationJsonFranchise : Json
        {
            private IEnumerable<Franchise> allFranchisesSorted;
            public IEnumerable<Franchise> AllFranchisesSorted
            {
                get
                {
                    if (allFranchisesSorted == null)
                    {
                        allFranchisesSorted = (this.Data as Corporation).AllFranchises;
                    }
                    return allFranchisesSorted;
                }
                set
                {
                    allFranchisesSorted = value;
                }
            }


            void Handle(Input.CreateFranchiseTrigger action)
            {
                new Franchise()
                {
                    FranchiseName = this.FranchiseName,
                    //TODO: how to get the current Item in the collection
                    Owner = this.Data as Corporation
                };

                Transaction.Commit();
            }

            void Handle(Input.SortOnTrigger action)
            {
                var corp = this.Data as Corporation;
                switch (action.Value)
                {
                    case 5: //HomeSold

                        this.AllFranchisesSorted = corp.AllFranchises
                            .OrderByDescending(x => x.HouseSold);
                        break;
                    case 6:
                        this.AllFranchisesSorted = corp.AllFranchises
                            .OrderByDescending(x => x.TotalCommission);
                        break;
                    case 7:
                        this.AllFranchisesSorted = corp.AllFranchises
                            .OrderByDescending(x => x.AverageCommission);
                        break;
                    case 8:
                        this.AllFranchisesSorted = corp.AllFranchises
                            .OrderByDescending(x => x.SalesTrend);
                        break;
                    default:
                        break;
                }
            }

            private void RefereshFranchise(FranchiseKPIs sortingKPI)
            {

            }

            private enum FranchiseKPIs { HomeSold = 5, TotalCommission, AverageCommission, PositiveTrend }

        }
    }

    
}
